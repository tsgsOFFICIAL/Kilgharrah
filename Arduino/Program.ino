#include <Stepper.h>

// Pin connections
// Stepper motor & driver
const short IN1Pin = 2;
const short IN2Pin = 3;
const short IN3Pin = 4;
const short IN4Pin = 5;
const short stepsPerRevolution = 2048;
const short motorSpeed = 15;

// Create stepper object called 'stepper', note the pin order:
Stepper stepper = Stepper(stepsPerRevolution, 2, 4, 3, 5);

short UfoLeds[] =
    {
        8,
        11,
        10,
        9};
//------------------------------------------------------------------------------------------------comeneted for test
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

int PlanetPositions[] =
    {
        0,   // Mercury
        1412,  // Venus
        2499,  // Earth
        3531,  // Mars
        6302,  // Jupiter
        10648, // Saturn
        21295, // Uranus
        27325, // Neptune
        32378  // Pluto
};



// Amount of steps taken
int CurrentPosition = 0;

// It takes 1.953125ms per step on the motor
const double msPerStep = 1.953125;

void setup()
{
  // Max 15 RPM @ 5V
 // stepper.setSpeed(motorSpeed);
  Serial.begin(9600);

  // Set all planets as output
  for (int i = 0; i < sizeof(PlanetLeds)/sizeof(short); i++)
  {
    pinMode(PlanetLeds[i], OUTPUT);
  }

  // Set all UFO Leds as output
  for (int i = 0; i < sizeof(UfoLeds)/sizeof(short); i++)
  {
    pinMode(UfoLeds[i], OUTPUT);
  }
}

//Main loop, controlling the UFO movements and blinking and planets light on and off
void loop()
{
  // Check if data is available & read it
  if (Serial.available() > 0)
  {
    String incomingString = Serial.readString(); // Read the incoming string

    if (incomingString == "moveToStart")
    {
      int stepsToTake = 0 - CurrentPosition;

      turnOffPlanets();
      moveAndBlink(stepsToTake);
    }
    else if (incomingString == "moveToMercury")
    {
      int stepsToTake = PlanetPositions[0] - CurrentPosition;

      turnOffPlanets();
      moveAndBlink(stepsToTake);
      turnOnPlanet(PlanetLeds[0]);
    }
    else if (incomingString == "moveToVenus")
    {
      int stepsToTake = PlanetPositions[1] - CurrentPosition;

      turnOffPlanets();
      moveAndBlink(stepsToTake);
      turnOnPlanet(PlanetLeds[1]);
    }
    else if (incomingString == "moveToEarth")
    {
      int stepsToTake = PlanetPositions[2] - CurrentPosition;

      turnOffPlanets();
      moveAndBlink(stepsToTake);
      turnOnPlanet(PlanetLeds[2]);
    }
    else if (incomingString == "moveToMars")
    {
      int stepsToTake = PlanetPositions[3] - CurrentPosition;

      turnOffPlanets();
      moveAndBlink(stepsToTake);
      turnOnPlanet(PlanetLeds[3]);
    }
    else if (incomingString == "moveToJupiter")
    {
      int stepsToTake = PlanetPositions[4] - CurrentPosition;

      turnOffPlanets();
      moveAndBlink(stepsToTake);
      turnOnPlanet(PlanetLeds[4]);
    }
    else if (incomingString == "moveToSaturn")
    {
      int stepsToTake = PlanetPositions[5] - CurrentPosition;

      turnOffPlanets();
      moveAndBlink(stepsToTake);
      turnOnPlanet(PlanetLeds[5]);
    }
    else if (incomingString == "moveToUranus")
    {
      int stepsToTake = PlanetPositions[6] - CurrentPosition;

      turnOffPlanets();
      moveAndBlink(stepsToTake);
      turnOnPlanet(PlanetLeds[6]);
    }
    else if (incomingString == "moveToNeptune")
    {
      int stepsToTake = PlanetPositions[7] - CurrentPosition;

      turnOffPlanets();
      moveAndBlink(stepsToTake);
      turnOnPlanet(PlanetLeds[7]);
    }
    else if (incomingString == "moveToPluto")
    {
      int stepsToTake = PlanetPositions[8] - CurrentPosition;

      turnOffPlanets();
      moveAndBlink(stepsToTake);
      turnOnPlanet(PlanetLeds[8]);
    }
    else if (incomingString == "test")
    {
      moveAndBlink(-PlanetPositions[8]);
    }
  }
  else
  {
    // Fade in
    for (int i = 0; i <= 255; i += 5)
    {
      for (int j = 0; j < sizeof(UfoLeds) / sizeof(short); j++)
      {
        analogWrite(UfoLeds[j], i);

        delay(5);
      }
    }

    // Fade out
    for (int i = 255; i >= 0; i -= 5)
    {
      for (int j = 0; j < sizeof(UfoLeds) / sizeof(short); j++)
      {
        analogWrite(UfoLeds[j], i);

        delay(5);
      }
    }
  }
}

// Blink the UFO Leds in a circular motion twice
void blinkUfo(int iterations)
{
  int delayTime = 50;

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
  if (stepsToTake > 0)
  {
    while (stepsToTake > stepsPerRound)
    {
      stepper.step(stepsPerRound);
      stepsToTake -= stepsPerRound;

      CurrentPosition += stepsPerRound;

      blinkUfo(1);
    }
  }
  else
  {
    while (stepsToTake < stepsPerRound)
    {
      stepper.step(stepsPerRound);
      stepsToTake += stepsPerRound;

      CurrentPosition -= stepsPerRound;

      blinkUfo(1);
    }
  }

  stepper.step(stepsToTake);
  CurrentPosition += stepsToTake;

  blinkUfo(5);
}

//Blinks the ufo 5 times, and moving to the planet connected with the incomming string
void moveAndBlink(int stepsToTake)
{
  int delayTime = 100;
  int stepsPerRound = round(delayTime / msPerStep);

  blinkUfo(5);
  turnOnMotor();
  if (stepsToTake >= 0)
  {
    while (stepsToTake > stepsPerRound)
    {
      for (int i = 0; i < sizeof(UfoLeds) / sizeof(short); i++)
      {
        if (i == 0)
        {
          analogWrite(UfoLeds[(sizeof(UfoLeds) / sizeof(short)) - 1], 0);
          stepper.step(stepsPerRound);
          stepsToTake -= stepsPerRound;
          CurrentPosition += stepsPerRound;
          analogWrite(UfoLeds[i], 255);
          stepper.step(stepsPerRound);
          stepsToTake -= stepsPerRound;
          CurrentPosition += stepsPerRound;
        }
        else if (i == 3)
        {
          analogWrite(UfoLeds[i - 1], 0);
          stepper.step(stepsPerRound);
          stepsToTake -= stepsPerRound;
          CurrentPosition += stepsPerRound;
          analogWrite(UfoLeds[i], 255);
          stepper.step(stepsPerRound);
          stepsToTake -= stepsPerRound;
          CurrentPosition += stepsPerRound;
          analogWrite(UfoLeds[i], 0);
          stepper.step(stepsPerRound);
          stepsToTake -= stepsPerRound;
          CurrentPosition += stepsPerRound;
        }
        else
        {
          analogWrite(UfoLeds[i - 1], 0);
          stepper.step(stepsPerRound);
          stepsToTake -= stepsPerRound;
          CurrentPosition += stepsPerRound;
          analogWrite(UfoLeds[i], 255);
          stepper.step(stepsPerRound);
          stepsToTake -= stepsPerRound;
          CurrentPosition += stepsPerRound;
        }
      }
    }
    stepper.step(stepsToTake);
    CurrentPosition += stepsToTake;
  }
  else
  {
    while (stepsToTake < stepsPerRound)
    {
      for (int i = 0; i < sizeof(UfoLeds) / sizeof(short); i++)
      {
        if (i == 0)
        {
          analogWrite(UfoLeds[(sizeof(UfoLeds) / sizeof(short)) - 1], 0);
          stepper.step(-stepsPerRound);
          stepsToTake += stepsPerRound;
          CurrentPosition -= stepsPerRound;
          analogWrite(UfoLeds[i], 255);
          stepper.step(-stepsPerRound);
          stepsToTake += stepsPerRound;
          CurrentPosition -= stepsPerRound;
        }
        else if (i == 3)
        {
          analogWrite(UfoLeds[i - 1], 0);
          stepper.step(-stepsPerRound);
          stepsToTake += stepsPerRound;
          CurrentPosition -= stepsPerRound;
          analogWrite(UfoLeds[i], 255);
          stepper.step(-stepsPerRound);
          stepsToTake += stepsPerRound;
          CurrentPosition -= stepsPerRound;
          analogWrite(UfoLeds[i], 0);
          stepper.step(-stepsPerRound);
          stepsToTake += stepsPerRound;
          CurrentPosition -= stepsPerRound;
        }
        else
        {
          analogWrite(UfoLeds[i - 1], 0);
          stepper.step(-stepsPerRound);
          stepsToTake += stepsPerRound;
          CurrentPosition -= stepsPerRound;
          analogWrite(UfoLeds[i], 255);
          stepper.step(-stepsPerRound);
          stepsToTake += stepsPerRound;
          CurrentPosition -= stepsPerRound;
        }
      }
    }
    stepper.step(stepsToTake);
    CurrentPosition = stepsToTake;
  }
  turnOffMotor();
  blinkUfo(5);
}

//Function to turn on the light inside the planet, when the UFO arrives
void turnOnPlanet(short planetPin)
{
  analogWrite(planetPin, 255);
}

//Function to turn off the light in the planet, when the UFO leaves the planet.
void turnOffPlanets()
{
  for (int i = 0; i < sizeof(PlanetLeds) / sizeof(short); i++)
  {
    analogWrite(PlanetLeds[i], 0);
  }
}

//Turn on the motor befor moving
void turnOnMotor()
{
  stepper.setSpeed(motorSpeed);
}

//Turn off the motor cutting the power to avoid overheating
void turnOffMotor()
{
  digitalWrite(IN1Pin,LOW);
  digitalWrite(IN2Pin,LOW);
  digitalWrite(IN3Pin,LOW);
  digitalWrite(IN4Pin,LOW);
}