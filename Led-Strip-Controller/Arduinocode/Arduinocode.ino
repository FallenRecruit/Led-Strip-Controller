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
String val = Serial.readString(); 

String a = getValue(val, ':', 0);
String r = getValue(val, ':', 1);
String g = getValue(val, ':', 2);
String b = getValue(val, ':', 3);

int _a = a.toInt();
int _r = r.toInt();
int _g = g.toInt();
int _b = b.toInt();

//Serial.flush(); // clear serial port
if (val != 0){
  Serial.print(val + " " + _r + " " + _g + " " + _b);
  analogWrite(redLedPin,_r);
  analogWrite(greenLedPin,_g);
  analogWrite(blueLedPin,_b);
  }
}

String getValue(String data, char separator, int index)
{
    int found = 0;
    int strIndex[] = { 0, -1 };
    int maxIndex = data.length() - 1;

    for (int i = 0; i <= maxIndex && found <= index; i++) {
        if (data.charAt(i) == separator || i == maxIndex) {
            found++;
            strIndex[0] = strIndex[1] + 1;
            strIndex[1] = (i == maxIndex) ? i+1 : i;
        }
    }
    return found > index ? data.substring(strIndex[0], strIndex[1]) : "";
}
