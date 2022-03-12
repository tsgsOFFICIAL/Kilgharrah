#include <Stepper.h>

// Pin connections:

// Stepper motor & driver
const short IN1Pin = 2;
const short IN2Pin = 3;
const short IN3Pin = 4;
const short IN4Pin = 5;
const short stepsPerRevolution = 2048;

// Create stepper object called 'stepper', note the pin order:
Stepper stepper = Stepper(stepsPerRevolution, 2, 4, 3, 5);

// UFO
const short UFOPin1 = A0;
const short UFOPin2 = A1;
const short UFOPin3 = A2;
const short UFOPin4 = A3;

// Planets
const short MercuryLedPin = A4;
const short VenusLedPin = A5;
const short EarthLedPin = A6;
const short MarsLedPin = A7;
const short JupiterLedPin = A8;
const short SaturnLedPin = A9;
const short UranusLedPin = A10;
const short NeptuneLedPin = A11;
const short PlutoyLedPin = A12;

void setup() {
  // Max 15 RPM
  stepper.setSpeed(15);
}

void loop() {
  moveUfo(stepsPerRevolution);
  delay(1 * 1000);
}

// stepsToTake = How many steps to take, negative values is reverse
void moveUfo(int stepsToTake) {
  stepper.step(stepsToTake);
}
