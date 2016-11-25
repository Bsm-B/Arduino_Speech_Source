///////////////////////////////
//    Bessem Bousselmi       //
// bsmbousselmi@gmail.com    //
//                           //
// Creative Commons CC-BY-NC //
///////////////////////////////
int ledpin = 13;
int ledpin2 = 12;
int ledpin3 = 11;
int ledpin4 = 10;
int value;
void setup ()
{
  Serial.begin(9600);
  pinMode(ledpin, OUTPUT);
  pinMode(ledpin2, OUTPUT);
  pinMode(ledpin3, OUTPUT);
  pinMode(ledpin4, OUTPUT);
}
void loop ()
{
  value = Serial.read();
  if (value == '1' ) {digitalWrite(ledpin, HIGH);}
  else if (value == '2'){digitalWrite(ledpin,LOW );}
  else if (value == '3' ) {digitalWrite(ledpin2, HIGH);}
  else if (value == '4'){digitalWrite(ledpin2,LOW );}
  else if (value == '5' ) {digitalWrite(ledpin3, HIGH);}
  else if (value == '6'){digitalWrite(ledpin3,LOW );}
  else if (value == '7' ) {digitalWrite(ledpin4, HIGH);}
  else if (value == '8'){digitalWrite(ledpin4,LOW );}
}
