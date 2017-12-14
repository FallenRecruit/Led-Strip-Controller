int redLedPin = 11;
int greenLedPin = 10;
int blueLedPin = 9;

int incomingByte = 0;

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
  
  // read the incoming byte:
  int incomingByte = Serial.read();
  if (incomingByte != -1) 
  {
    //Serial.flush(); // clear serial port
    
    Serial.print(incomingByte);
    if (incomingByte > 999 && incomingByte < 2000)
    {
      int _r = incomingByte - 1000;
      analogWrite(redLedPin,_r);
    }
    else if (incomingByte > 1999 && incomingByte < 3000)
    {
      int _g = incomingByte - 2000;
      analogWrite(greenLedPin,_g);
    }
    else if (incomingByte > 2999)
    {
      int _b = incomingByte - 3000;
      analogWrite(blueLedPin,_b);
    }
  }
}
