void setup() {
  Serial.begin(9600);

}

void loop() {
  //#_mode_datafu_datanfu_rotary_dataauto_\n

  Serial.print("#");  Serial.print("_");
  Serial.print("0");  Serial.print("_");
  Serial.print("35");  Serial.print("_");
  Serial.print("34");  Serial.print("_");
  Serial.print("50");  Serial.print("_");
  Serial.print("90");  Serial.print("_");
  Serial.print("\n");
  delay(1000);

  Serial.print("#");  Serial.print("_");
  Serial.print("1");  Serial.print("_");
  Serial.print("0");  Serial.print("_");
  Serial.print("1");  Serial.print("_");
  Serial.print("60");  Serial.print("_");
  Serial.print("180");  Serial.print("_");
  Serial.print("\n");
  delay(1000);

  Serial.print("#");  Serial.print("_");
  Serial.print("2");  Serial.print("_");
  Serial.print("0");  Serial.print("_");
  Serial.print("1");  Serial.print("_");
  Serial.print("70");  Serial.print("_");
  Serial.print("270");  Serial.print("_");
  Serial.print("\n");
  delay(1000);
}
