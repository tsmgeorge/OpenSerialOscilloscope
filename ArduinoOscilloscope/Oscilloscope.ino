#include <avr/wdt.h> //for watchdog
           //Arduino  //ATMEGA
#define LedState 8    //pin 14
#define Vin A1        //pin 24

unsigned long int startTime=0;
unsigned long int tempTime=0;

bool prevLedState=false;
int timeValue=70;

// I N T E R F A C E

//Blink (ON-OFF) the selected led for specific time in millisecond
void BlinkLed(int led, int blTimes, int millitime){
  for(int i=0;i<blTimes;i++){
    digitalWrite( led,HIGH);
    delay(millitime);
    digitalWrite( led,LOW);
    delay(millitime);
  }//for
}//Blick Led

//Reverse the led state
void ReverseLedState(int led){
  if(prevLedState==false){
    prevLedState=true;
    digitalWrite( led,HIGH);
  }//if false
  else{
    prevLedState=false;
    digitalWrite( led,LOW);
    }//else
}//Reverse Led State


//Blink led without delay the microcontroller functional circle 
void TimerBlinkLed(int maxTime){
    if( (millis()-tempTime >maxTime) ){
       tempTime=millis();
       ReverseLedState(LedState);
    }//if
}//Timer Blink Led


// C O M M U N I C A T I O N

//Use this class to build and oscilloscope object
class OSCobject{
  String timeMs="null";
  String ch1="null";
  String ch2="null";
  String msg;

  //Set channel 1 value
  public: void SetCH1(float val){
      this->ch1=FloatToString(val,2);
  }//SetCH1

  //Set channel 2 value
  public: void SetCH2(float val){
      this->ch2=FloatToString(val,2);
  }//SetCH1

  //This function is used by the object to build the 'send package'.
  private: void BuildPacket(){
     // unsigned long int currtime=millis()-startTime;
      this->timeMs=String(millis());
      this->msg=String(
         "T "+timeMs+" "
         "CH1 "+String(ch1)+" "
         "CH2 "+String(ch2)+" " 
      );
  }//BuildPacket

  //Send data via serial port
    public: void OscillSend(){
       char *temp;
       this->BuildPacket();
       temp=&this->msg[0];
          Serial.println(temp);
      // }//if data
     return temp;
    }//OscSend
};


// U T I L I T I E S

//Convert a floating value to String
  String FloatToString(float flt, int presisionNum ){
   unsigned int TempInt= flt;   // get the integer part of float
    float TempFlt= flt-TempInt; // get the demical part of float
   unsigned int TempDec=  TempFlt*(pow(10,presisionNum)); //get demical in presision
   // int TempDec= TempFlt*100; //get demical in presision
    String FtoStrTemp="";
      FtoStrTemp=  TempInt;
      FtoStrTemp+= ",";
    if(TempDec<10){ //if only one dec 
     // FtoStrTemp+= "0";
        for(int i=0;i<(presisionNum-1);i++){ FtoStrTemp+= "0";}
       }//if
      FtoStrTemp+= TempDec;
    return FtoStrTemp;  
  }//Float to String


// M E A S U R E M E N T S

//Calculate average of a number of measurments
float GetSample(int input,int sample){
  if(sample==0){return 0.0;}
  float measure=0.0;
  float sum=0.0;
  for(int i=0;i<sample;i++){
    measure= analogRead(input);
    sum= sum +measure;
   // delay(1);
  }//for
  float stableMeasure= sum/sample;
  return stableMeasure;
}//Get Sample


//Get average from voltage divider
float GetVoltageDv(int input){
  float measureVolt= GetSample(input,10);
  const float MaxVolt=4.85;
  const float encMaxVal=1023.0;
  const float R1=60000;
  const float R2=15000;
  float Vs= (measureVolt*(R1+R2))/R2;
  float volt= Vs* (MaxVolt/encMaxVal);
  return volt;
}//GetVoltage



// S E T U P

void setup() {
  Serial.begin(115200);
  pinMode(LedState,OUTPUT); //State led pin-> output
  pinMode(Vin,INPUT);       //VoltageDivider input to ADC
  digitalWrite(LedState,LOW); //Set led state
  startTime=millis();         //Initillize start time
  wdt_enable(WDTO_4S);      //watchdog enabled (if not reset until 4 second pass, reset Microcontroller)
}//setup


// M a i n

void loop() {
  wdt_reset();    //reset watchdog 
  OSCobject Osc;  //Oscilloscope Object
  float volt= GetVoltageDv(Vin); //get volt
  Osc.SetCH1(volt);     //store volt value to channel 1
  //Osc.SetCH2(volt2);  //store volt value to channel 2
  Osc.OscillSend();     //build data and send that to serial

  TimerBlinkLed(250); //blink 2 times at a second (ON 250ms, OFF 250ms)x2
  
  if(Serial.available() > 0) {    //if there is incoming data from open serial oscilloscope software
    String incomingByte = Serial.readString(); //read string ()
    int intVal= incomingByte.toInt();          // convert to int
    if(intVal>0){timeValue=intVal;}            // data= hardware delay (to set signal resolution)
  }//while
  delay(timeValue); //delay with last valid timeValue
  //BlinkLed(LedState,1,200);
}//main
