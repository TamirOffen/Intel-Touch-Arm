#include <Servo.h>


int xLoc, yLoc, MAX_X, MAX_Y, TAP_DELAY = 0;
const int stepPinHoriz = 3, dirPinHoriz = 5, stepPinVert = 12, dirPinVert = 8,
          enablePinHoriz = 11, enablePinVert = 13, servoPin = 7; 

Servo servo;

void setup() {
  xLoc = 0, yLoc = 0, MAX_X = 600, MAX_Y = 750;

  // TODO: pinModes for motors 
  pinMode(stepPinHoriz, OUTPUT);
  pinMode(dirPinHoriz, OUTPUT);
  pinMode(stepPinVert, OUTPUT);
  pinMode(dirPinVert, OUTPUT);

  // enable pins
  pinMode(enablePinHoriz, OUTPUT); 
  pinMode(enablePinVert, OUTPUT);
  digitalWrite(enablePinHoriz, HIGH);
  digitalWrite(enablePinVert, HIGH); 
  
  Serial.begin(9600);

  //help();
}

void loop() {

  String msg = "";

  if(Serial.available() > 0) msg = Serial.readString();
  
  if(msg.equals("help")) help();
  else if(msg.equals("reset")) resetLoc();
  else if(msg.substring(0,4).equals("move")) {
    if(msg.substring(msg.indexOf("e") + 1, msg.indexOf("z") + 1).equals("Horiz")) {
      moveHoriz(atoi( msg.substring(msg.indexOf("(") + 1, msg.indexOf(")")).c_str() ));
    }
    if(msg.substring(msg.indexOf("e") + 1, msg.indexOf("t") + 1).equals("Vert")) {
      moveVert(atoi( msg.substring(msg.indexOf("(") + 1, msg.indexOf(")")).c_str() ));
    }
  }
  else if(msg.substring(0, 13).equals("setScreenSize")) {
    int width = atoi( msg.substring(msg.indexOf("(") + 1, msg.indexOf(",")).c_str() );
    int height = atoi( msg.substring(msg.indexOf(",") + 1, msg.indexOf(")")).c_str() );
    setSize(width, height);
  }
  else if(msg.substring(0,3).equals("tap")){
    if(msg.substring(msg.indexOf(",")+1, msg.indexOf(")")).equals("true")) tap(0, true);
    else {
      TAP_DELAY = atoi( msg.substring(4, msg.indexOf(")")).c_str() );
      tap(TAP_DELAY,false);
    }
  }
  else if(msg.substring(0,5).equals("swipe")) {
    String motorDir = msg.substring(msg.indexOf("(") + 1, msg.indexOf(","));
    int amt = atoi( msg.substring(msg.indexOf(",") + 1, msg.indexOf(")")).c_str() );
    swipe(motorDir, amt);
  }
  else if(msg.equals("pinch")) pinch(); 
  else if(msg.equals("program")) program();

  // //
  else if(msg.equals("getCurrXpos")) getCurrXpos(); 
  else if(msg.equals("getCurrYpos")) getCurrYpos();
  else if(msg.indexOf('P') == 0) debugPin(
    atoi(msg.substring(1, msg.indexOf(' ')).c_str()),
    atoi(msg.substring(msg.indexOf(' ')+1).c_str())
    );

}

void debugPin(int dbgpin, int dbgval) {
  digitalWrite(dbgpin, (dbgval > 0 ? HIGH : LOW));
  Serial.print(F("Setting Pin:"));
  Serial.print(dbgpin);
  Serial.print(" ");
  Serial.println((dbgval > 0 ? F("HIGH") : F("LOW")));
}

// displays list of methods
void help() {
  Serial.println("\nList of commands:");
  Serial.println("\tMove the arm horizontally: ");
  Serial.println("\t\tâ€¢ moveHoriz(amount)  |  amount is an integer value. A positive amount corresponds with right and negetive with left."); // TODO fix wording
  Serial.println("\tMove the arm vertically: ");
  Serial.println("\t\tâ€¢ moveVert(amount)   |  amount is an integer value. A positive amount corresponds with up and negetive with down."); // TODO fix wording
  Serial.println("\tReset the location of the arm: ");
  Serial.println("\t\tâ€¢ reset  |  moves the arm back to its orginal position(bottom left).");
  Serial.println("\tTap the screen: ");
  Serial.println("\t\tâ€¢ tap  |  taps the screen");
  Serial.println("\tPinch the screen: ");
  Serial.println("\t\tâ€¢ pinch  |  zooms in");
  Serial.println("\tSet screen size:");
  Serial.println("\t\tâ€¢ setScreenSize(width,height)  |  Width and height are both integers that are larger than 0.\n\t\t\t\t\t       |  Original preset is width of 100 and height of 100.");
  Serial.println("\tFor more information: ");
  Serial.println("\t\tâ€¢ help  |  display all methods");
}

// resets location to (0,0) bottom left
void resetLoc() {
  moveHoriz(-xLoc);
  moveVert(-yLoc);
  Serial.println("Reset location");
}

// sets the size of the screen
// width and height have to be greater than 0
void setSize(int width, int height) {
  if(width <= 0 || height <= 0) {
    Serial.println("Error: width and height must be greater than 0");
    Serial.println("");
  }
  else {
    MAX_X = width;
    MAX_Y = height;
    Serial.println("New dimensions:");
    Serial.print("Width: ");
    Serial.print(MAX_X);
    Serial.print("\tHeight: ");
    Serial.println(MAX_Y); 
  }
}

// moves the arm horizontally right(pos amt) or left(neg amt)
// doesn't move if final x-location will be less than 0 or greater than MAX_X
void moveHoriz(int amt) {
  if(xLoc + amt < 0) Serial.println("Error: x location cannot be less than 0");
  else if(xLoc + amt > MAX_X) {
    Serial.print("Error: x location cannot exceed the max width("); 
    Serial.print(MAX_X);
    Serial.println(")");
  }
  else {
    // Stepper:
    String dir = "";
    if(amt > 0) dir = "counterclockwise";
    else if(amt < 0) dir = "clockwise";
    else return; 

    stepperRotate(dirPinHoriz, stepPinHoriz, enablePinHoriz, dir, amt);

    xLoc += amt;
    Serial.print("Moved horizontally by ");
    Serial.println(amt);
    
  }
}

// moves the arm vertically up(pos amt) or down(neg amt)
// doesn't move if final y-location will be less than 0 or greater than MAX_Y
void moveVert(int amt) {
  if(yLoc + amt < 0) Serial.println("Error: y location cannot be less than 0");
  else if(yLoc + amt > MAX_Y) {
    Serial.print("Error: y location cannot exceed the max height("); 
    Serial.print(MAX_Y);
    Serial.println(")");
  }else {
    // Stepper:
    String dir = "";
    if(amt > 0) dir = "clockwise";
    else if(amt < 0) dir = "counterclockwise";
    else return; 

    stepperRotate(dirPinVert, stepPinVert, enablePinVert, dir, amt);

    yLoc += amt;
    Serial.print("Moved vertically by ");
    Serial.println(amt);
  }
}

// moves the arm in the z-axis to tap the screen
void tap(int tapDur, boolean doubleTap) {
  servo.attach(servoPin);

  if(doubleTap) {
    int pos = 0;
    for (pos = 0; pos <= 100; pos++) { 
      servo.write(pos);              
      delay(15);                       
    }
    for (pos = 100; pos <= 120; pos++) {
      servo.write(pos);
      delay(2);
    }
    for (pos = 170; pos >= 100; pos--) {
      servo.write(pos);
      delay(2);
    }
    for (pos = 100; pos <= 120; pos++) {
      servo.write(pos);
      delay(2);
    }
    for (pos = 170; pos >= 100; pos--) {
      servo.write(pos);
      delay(2);
    }
    for (pos = 100; pos >= 0; pos--) { 
      servo.write(pos);              
      delay(15);                       
    }

    Serial.println("Double tapped");
  } else {
    int pos = 0;
    //120 is the max dist to phone
    for(pos; pos <= 125; pos++) {
      servo.write(pos);
      delay(15);
    }

    delay(tapDur);

    for(pos; pos >= 0; pos--) {
      servo.write(pos);
      delay(15);
    }

    

    Serial.print("Screen tapped with a delay of ");
    Serial.print(tapDur);
    Serial.println(" milliseconds");
  }

  servo.detach();
}

void swipe(String motor, int amt) {
  Serial.println("Swipe started...");
  //tap (but don't come back up):
  servo.attach(servoPin);
  int pos = 0;
  for(pos; pos <= 122; pos++) {
      servo.write(pos);
      if(pos<122) delay(15);
  }
  //servo.detach();

  // move the arm:  
  if(motor.equals("horiz")) {
    xLoc+=amt;
    String dir = "";
    if(amt > 0) dir = "counterclockwise";
    else if(amt < 0) dir = "clockwise";
    else return;
    stepperRotate(dirPinHoriz, stepPinHoriz, enablePinHoriz, dir, amt);
  } 
  else if (motor.equals("vert")) {
    yLoc += amt;
    String dir = "";
    if(amt > 0) dir = "clockwise";
    else if(amt < 0) dir = "counterclockwise";
    else return;
    stepperRotate(dirPinVert, stepPinVert, enablePinVert, dir, amt);
  }

  // bring arm back up:
  //servo.attach(servoPin);
  for(pos; pos >= 0; pos--) {
      servo.write(pos);
      delay(15);
  }
  servo.detach();

  Serial.println("Swipe finished");
}

/*
 * Example program
 * Description: Opens phone, goes to instagram - my profile - my feed - my most recent post - likes it, goes back to home
 */
void program() {
  // double tap bottom to turn on display
  Serial.println("Turning on display");
  moveHoriz(250); //moves right to the square thing
  moveVert(20);
  tap(0, true); // double taps the square thing

  // swipe up to try to unlock phone
  Serial.println("Swipping to unlock");
  moveVert(50); //moves arm up a bit
  swipe("vert", 225); //swipes the phone upwards


  // type in password and tap 'ok'
  Serial.println("Typing in password...");
  
    //go to the number 1:
    moveVert(-20); moveHoriz(-100); tap(0, false);
    //go to the number 3:
    moveHoriz(200); tap(0, false);
    //go to the number 6:
    moveVert(-50); tap(0, false);
    //go to the number 9:
    moveVert(-50); tap(0, false);
    // go to 'ok':
    moveVert(-50); tap(0, false);
   
  Serial.println("Done. Phone is now unlocked");

  // tap instagram
  moveHoriz(-40); //move left
  moveVert(90); //move up;
  tap(0, false);

  // tap on 'my profile' 
  moveVert(-165); //move down to the bottom navigation bar
  moveHoriz(75); //moves right to 'my profile'
  tap(0, false);

  // tap on 'my feed'
  moveVert(405); //move up to the top navigation bar
  moveHoriz(-150); //move left to the 'my feed' button
  tap(0, false);

  // scroll down to the most recent post
  moveVert(-250);
  swipe("vert", 200); //swipes up to show the most recent post

  // double tap to like
  tap(0, true);

  // tap home button
  moveVert(-390);
  moveHoriz(15);
  tap(0, false);

  // reset position of arm
  resetLoc();
  
}


// zooms into the screen
void pinch() {
  // TODO
}

// rotates the stepper motor in a certain direction a given amount
// dir could be either clockwise or counterclockwise 
void stepperRotate(int dirPin, int stepPin, int enablePin, String dir, int amt) {
  amt = abs(amt);
  if(strcmp("clockwise",dir.c_str()) == 0){
    digitalWrite(dirPin, HIGH);
  }else if(dir.equals("counterclockwise")){
    digitalWrite(dirPin, LOW);
  }else Serial.println("Code Error: 'dir' is not valid!");

  digitalWrite(enablePin, LOW);
  //digitalWrite(enablePinVert, LOW);
  
  delay(500);

  for(int i = 0; i < amt; i++) {
    digitalWrite(stepPin, HIGH);
    delayMicroseconds(1000);
    digitalWrite(stepPin, LOW);
    delayMicroseconds(1000);
  }

  digitalWrite(enablePin, HIGH);
  //digitalWrite(enablePinVert, HIGH);
}

void getCurrXpos() { Serial.println(xLoc); }

void getCurrYpos() { Serial.println(yLoc); }


