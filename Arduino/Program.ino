#include <Stepper.h>

// Pin connections
// Stepper motor & driver
const short IN1Pin = 2;
const short IN2Pin = 3;
const short IN3Pin = 4;
const short IN4Pin = 5;
const short stepsPerRevolution = 2048;

// Create stepper object called 'stepper', note the pin order:
Stepper stepper = Stepper(stepsPerRevolution, 2, 4, 3, 5);

short UfoLeds[] =
{
  8,
  11,
  10,
  9
};

short PlanetLeds[] =
{
  A4,  // Mercury
  A5,  // Venus
  A6,  // Earth
  A7,  // Mars
  A8,  // Jupiter
  A9,  // Saturn
  A10, // Uranus
  A11, // Neptune
  A12  // Pluto
};

short PlanetPositions[] =
{
  217,   // Mercury
  1630,  // Venus
  2716,  // Earth
  3694,  // Mars
  6519,  // Jupiter
  10865, // Saturn
  21564, // Uranus
  27607, // Neptune
  32595  // Pluto
};

/*

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
const short PlutoLedPin = A12;

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
*/

// Amount of steps taken
int CurrentPosition = 0;

// It takes 5.859375ms per step on the motor
const double msPerStep = 5.859375;

void setup() {
  // Max 15 RPM @ 5V
  stepper.setSpeed(15);
  Serial.begin(9600);
  
  // Set all planets as output
  for (int i = 0; i < sizeof(PlanetLeds); i++)
  {
    pinMode(PlanetLeds[i], OUTPUT);
  }

  // Set all UFO Leds as output
  for (int i = 0; i < sizeof(UfoLeds); i++)
  {
    pinMode(UfoLeds[i], OUTPUT);
  }
}

void loop() {
  // Check if data is available & read it
  if (Serial.available() > 0)
  {
    String incomingString = Serial.readString(); // Read the incoming string
    
    // prints the received data
    //Serial.print("I received: ");
    //Serial.println(incomingString);

    if (incomingString == "moveToStart")
    {
      int stepsToTake = 0 - CurrentPosition;

      turnOffPlanets();
      moveUfo(stepsToTake);
    }
    else if (incomingString == "moveToMercury")
    {
      int stepsToTake = PlanetPositions[0] - CurrentPosition;

      turnOffPlanets();
      moveUfo(stepsToTake);
      turnOnPlanet(PlanetLeds[0]);
    }
    else if (incomingString == "moveToVenus")
    {
      int stepsToTake = PlanetPositions[1] - CurrentPosition;
      
      turnOffPlanets();
      moveUfo(stepsToTake);
      turnOnPlanet(PlanetLeds[1]);
    }
    else if (incomingString == "moveToEarth")
    {
      int stepsToTake = PlanetPositions[2] - CurrentPosition;
      
      turnOffPlanets();
      moveUfo(stepsToTake);
      turnOnPlanet(PlanetLeds[2]);
    }
    else if (incomingString == "moveToMars")
    {
      int stepsToTake = PlanetPositions[3] - CurrentPosition;
      
      turnOffPlanets();
      moveUfo(stepsToTake);
      turnOnPlanet(PlanetLeds[3]);
    }
    else if (incomingString == "moveToJupiter")
    {
      int stepsToTake = PlanetPositions[4] - CurrentPosition;
      
      turnOffPlanets();
      moveUfo(stepsToTake);
      turnOnPlanet(PlanetLeds[4]);
    }
    else if (incomingString == "moveToSaturn")
    {
      int stepsToTake = PlanetPositions[5] - CurrentPosition;
      
      turnOffPlanets();
      moveUfo(stepsToTake);
      turnOnPlanet(PlanetLeds[5]);
    }
    else if (incomingString == "moveToUranus")
    {
      int stepsToTake = PlanetPositions[6] - CurrentPosition;
      
      turnOffPlanets();
      moveUfo(stepsToTake);
      turnOnPlanet(PlanetLeds[6]);
    }
    else if (incomingString == "moveToNeptune")
    {
      int stepsToTake = PlanetPositions[7] - CurrentPosition;
      
      turnOffPlanets();
      moveUfo(stepsToTake);
      turnOnPlanet(PlanetLeds[7]);
    }
    else if (incomingString == "moveToPluto")
    {
      int stepsToTake = PlanetPositions[8] - CurrentPosition;
      
      turnOffPlanets();
      moveUfo(stepsToTake);
      turnOnPlanet(PlanetLeds[8]);
    }
  }
  else
  {
    // Fade in
    for (int i = 0; i <= 255; i+=5)
    {
      for (int j = 0; j < sizeof(UfoLeds) / sizeof(short); j++)
      {
        analogWrite(UfoLeds[j], i);
          
        delay(5);
      }
    }

    // Fade out
    for (int i = 255; i >= 0; i-=5)
    {
      for (int j = 0; j < sizeof(UfoLeds) / sizeof(short); j++)
      {
        analogWrite(UfoLeds[j], i);
          
        delay(5);
      }
    }
    
  }
}

void blinkUfo(int iterations)
{
  int delayTime = 50;
  
  // Blink the UFO Leds in a circular motion twice
  for (int i = 0; i < iterations; i++)
  {
    for (int j = 0; j < sizeof(UfoLeds) / sizeof(short); j++)
    {
      if (j == 0)
      {
        analogWrite(UfoLeds[(sizeof(UfoLeds) / sizeof(short)) - 1], 0);
        delay(delayTime);
        analogWrite(UfoLeds[j], 255);
        delay(delayTime);
      }
      else if (j == 3)
      {
        analogWrite(UfoLeds[j - 1], 0);
        delay(delayTime);
        analogWrite(UfoLeds[j], 255);
        delay(delayTime);
        analogWrite(UfoLeds[j], 0);
        delay(delayTime);
      }
      else
      {
        analogWrite(UfoLeds[j - 1], 0);
        delay(delayTime);
        analogWrite(UfoLeds[j], 255);
        delay(delayTime);
      }
    }
  }
}

// stepsToTake = How many steps to take, negative values is reverse
void moveUfo(int stepsToTake)
{
  int stepsPerRound = 500;
  
  blinkUfo(5);

  while (stepsToTake > stepsPerRound)
  {
    stepper.step(stepsPerRound);
    stepsToTake -= stepsPerRound;
    
    CurrentPosition += stepsPerRound;
    
    blinkUfo(1);
  }

  stepper.step(stepsToTake);
  CurrentPosition += stepsToTake;
  
  blinkUfo(5);
}

void turnOnPlanet(short planetPin)
{
  analogWrite(planetPin, 255);
}

void turnOffPlanets()
{
  for (int i = 0; i < sizeof(PlanetLeds) / sizeof(short); i++)
  {
    analogWrite(PlanetLeds[i], 0);
  }
}
