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

// Steps from the sun
const short SunPosition = 0;
const short MercuryPosition = 217;
const short VenusPosition = 1630;
const short EarthPosition = 2716;
const short MarsPosition = 3694;
const short JupiterPosition = 6519;
const short SaturnPosition = 10865;
const short UranusPosition = 21564;
const short NeptunePosition = 27607;
const short PlutoPosition = 32595;

// Amount of steps taken
int CurrentPosition = 0;

const double msPerStep = 5.859375;

void setup() {
  // Max 15 RPM @ 5V
  stepper.setSpeed(15);
}

void loop() {
  // Check if data is available & read it
  if (Serial.available() > 0)
  {
    String incomingString = Serial.readString(); // Read the incoming string
    
    // prints the received data
    Serial.print("I received: ");
    Serial.println(incomingString);

    if (incomingString == "moveToSun")
    {
      int stepsToTake = SunPosition - CurrentPosition;
      int arrivalTime = msPerStep * stepsToTake;

      if (arrivalTime < 0)
      {
        arrivalTime = arrivalTime * -1;
      }
      
      moveUfo(stepsToTake);
    }
    else if (incomingString == "moveToMercury")
    {
      int stepsToTake = MercuryPosition - CurrentPosition;
      int arrivalTime = msPerStep * stepsToTake;

      if (arrivalTime < 0)
      {
        arrivalTime = arrivalTime * -1;
      }
      
      moveUfo(stepsToTake);
    }
    else if (incomingString == "moveToVenus")
    {
      int stepsToTake = VenusPosition - CurrentPosition;
      int arrivalTime = msPerStep * stepsToTake;

      if (arrivalTime < 0)
      {
        arrivalTime = arrivalTime * -1;
      }
      
      moveUfo(stepsToTake);
    }
    else if (incomingString == "moveToEarth")
    {
      int stepsToTake = EarthPosition - CurrentPosition;
      int arrivalTime = msPerStep * stepsToTake;

      if (arrivalTime < 0)
      {
        arrivalTime = arrivalTime * -1;
      }
      
      moveUfo(stepsToTake);
    }
    else if (incomingString == "moveToMars")
    {
      int stepsToTake = MarsPosition - CurrentPosition;
      int arrivalTime = msPerStep * stepsToTake;

      if (arrivalTime < 0)
      {
        arrivalTime = arrivalTime * -1;
      }
      
      moveUfo(stepsToTake);
    }
    else if (incomingString == "moveToJupiter")
    {
      int stepsToTake = JupiterPosition - CurrentPosition;
      int arrivalTime = msPerStep * stepsToTake;

      if (arrivalTime < 0)
      {
        arrivalTime = arrivalTime * -1;
      }
      
      moveUfo(stepsToTake);
    }
    else if (incomingString == "moveToSaturn")
    {
     int stepsToTake = SaturnPosition - CurrentPosition;
      int arrivalTime = msPerStep * stepsToTake;

      if (arrivalTime < 0)
      {
        arrivalTime = arrivalTime * -1;
      }
      
      moveUfo(stepsToTake);
    }
    else if (incomingString == "moveToUranus")
    {
      int stepsToTake = UranusPosition - CurrentPosition;
      int arrivalTime = msPerStep * stepsToTake;

      if (arrivalTime < 0)
      {
        arrivalTime = arrivalTime * -1;
      }
      
      moveUfo(stepsToTake);
    }
    else if (incomingString == "moveToNeptune")
    {
      int stepsToTake = NeptunePosition - CurrentPosition;
      int arrivalTime = msPerStep * stepsToTake;

      if (arrivalTime < 0)
      {
        arrivalTime = arrivalTime * -1;
      }
      
      moveUfo(stepsToTake);
    }
    else if (incomingString == "moveToPluto")
    {
      int stepsToTake = PlutoPosition - CurrentPosition;
      int arrivalTime = msPerStep * stepsToTake;

      if (arrivalTime < 0)
      {
        arrivalTime = arrivalTime * -1;
      }
      
      moveUfo(stepsToTake);
    }
  }
}

// stepsToTake = How many steps to take, negative values is reverse
void moveUfo(int stepsToTake) {
  stepper.step(stepsToTake);
}
