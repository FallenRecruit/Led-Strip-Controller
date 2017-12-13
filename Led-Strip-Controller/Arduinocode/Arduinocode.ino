int redLedPin = 9;
int greenLedPin = 10;
int blueLedPin = 11;

void setup() 
{
  Serial.begin(9600);
  pinMode(redLedPin, OUTPUT);
  pinMode(greenLedPin, OUTPUT);
  pinMode(blueLedPin, OUTPUT);
  analogWrite(redLedPin,255);
  analogWrite(greenLedPin,255);
  analogWrite(blueLedPin,255);
}

void loop() 
{
int val=Serial.read(); 

if(val==1)
{
  Serial.println("Led on");
  digitalWrite(ledPin,HIGH);
}
else if(val==0)
{
Serial.println("Led off");
digitalWrite(ledPin,LOW);
}
Serial.flush(); // clear serial port

}
