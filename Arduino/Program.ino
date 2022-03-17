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
const Stepper stepper = Stepper(stepsPerRevolution, 2, 4, 3, 5);

const short UfoLeds[] =
    {
        8,
        11,
        10,
        9
    };

const short PlanetLeds[] =
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

bool PlanetLock[] =
{
  false,
  false,
  false,
  false,
  false,
  false,
  false,
  false,
  false
};

const int PlanetPositions[] =
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

char input;

void setup()
{
  // Max 15 RPM @ 5V
  Serial.begin(9600);

  // Set all planets as output
  for (int i = 0; i < sizeof(PlanetLeds) / sizeof(short); i++)
  {
    pinMode(PlanetLeds[i], OUTPUT);
  }

  // Set all UFO Leds as output
  for (int i = 0; i < sizeof(UfoLeds) / sizeof(short); i++)
  {
    pinMode(UfoLeds[i], OUTPUT);
  }
}

// Main loop, controlling the UFO movements, blinking and planets light on & off
void loop()
{
  while (Serial.available() > 0)
  {
    input = Serial.read();

    switch (input)
    {
      case '0': // Mercury
        turnOffPlanets();
        moveAndBlink(PlanetPositions[0] - CurrentPosition);
        turnOnPlanet(PlanetLeds[0]);
        break;
      case 'q': // Mercury unlocked
        PlanetLock[0] = true;
        break;
      case '1': // Venus
        turnOffPlanets();
        moveAndBlink(PlanetPositions[1] - CurrentPosition);
        turnOnPlanet(PlanetLeds[1]);
        break;
      case 'w': // Venus unlocked
        PlanetLock[1] = true;
        break;
      case '2': // Earth
        turnOffPlanets();
        moveAndBlink(PlanetPositions[2] - CurrentPosition);
        turnOnPlanet(PlanetLeds[2]);
        break;
      case 'e': // Earth unlocked
        PlanetLock[2] = true;
        break;
      case '3': // Mars
        turnOffPlanets();
        moveAndBlink(PlanetPositions[3] - CurrentPosition);
        turnOnPlanet(PlanetLeds[3]);
        break;
      case 'r': // Mars unlocked
        PlanetLock[3] = true;
        break;
      case '4': // Jupiter
        turnOffPlanets();
        moveAndBlink(PlanetPositions[4] - CurrentPosition);
        turnOnPlanet(PlanetLeds[4]);
        break;
      case 't': // Jupiter unlocked
        PlanetLock[4] = true;
        break;
      case '5': // Saturn
        turnOffPlanets();
        moveAndBlink(PlanetPositions[5] - CurrentPosition);
        turnOnPlanet(PlanetLeds[5]);
        break;
      case 'y': // Saturn unlocked
        PlanetLock[5] = true;
        break;
      case '6': // Uranus
        turnOffPlanets();
        moveAndBlink(PlanetPositions[6] - CurrentPosition);
        turnOnPlanet(PlanetLeds[6]);
        break;
      case 'u': // Uranus unlocked
        PlanetLock[6] = true;
        break;
      case '7': // Neptune
        turnOffPlanets();
        moveAndBlink(PlanetPositions[7] - CurrentPosition);
        turnOnPlanet(PlanetLeds[7]);
        break;
      case 'i': // Neptune unlocked
        PlanetLock[7] = true;
        break;
      case '8': // Pluto
        turnOffPlanets();
        moveAndBlink(PlanetPositions[8] - CurrentPosition);
        turnOnPlanet(PlanetLeds[8]);
        break;
      case 'o': // Pluto unlocked
        PlanetLock[8] = true;
        break;
      default:
      break;
    }
  }
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

//Blinks the ufo 5 times, and moving to the planet connected with the incomming string
void moveAndBlink(int stepsToTake)
{
  int delayTime = 100;
  int stepsPerRound = round(delayTime / msPerStep);
  
  Serial.print("stepsToTake: "); // DEBUG
  Serial.println(stepsToTake); // DEBUG

  Serial.print("stepsPerRound: "); // DEBUG
  Serial.println(stepsPerRound); // DEBUG

  blinkUfo(5); // Blink UFO Led's
  turnOnMotor(); // Turn on the motor / Start the engine
  
  // MOVE HERE
  stepper.step(stepsToTake);
  CurrentPosition += stepsToTake;
  
  turnOffMotor(); // Turn off the motor / Stop the engine
  blinkUfo(5); // Blink UFO Led's

  Serial.print("CurrentPosition: "); // DEBUG
  Serial.println(CurrentPosition); // DEBUG
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

//Function to turn on the light inside the planet, when the UFO arrives
void turnOnPlanet(short planetPin)
{
  Serial.println("Turned on a planet"); // DEBUG
  
  analogWrite(planetPin, 255);
}

//Function to turn off the light in the planet, when the UFO leaves the planet.
void turnOffPlanets()
{
  Serial.println("Turning off planets"); // DEBUG
  
  for (int i = 0; i < sizeof(PlanetLeds) / sizeof(short); i++)
  {
    if (PlanetLock[i] == false)
    {
      analogWrite(PlanetLeds[i], 0);
    }
  }
  
  Serial.println("Turned off planets"); // DEBUG
}

// Turn on the motor befor moving
void turnOnMotor()
{
  Serial.println("Turned on motor"); // DEBUG
  
  stepper.setSpeed(motorSpeed);
}

// Turn off the motor cutting the power to avoid overheating
void turnOffMotor()
{
  digitalWrite(IN1Pin, LOW);
  digitalWrite(IN2Pin, LOW);
  digitalWrite(IN3Pin, LOW);
  digitalWrite(IN4Pin, LOW);
  
  Serial.println("Turned off motor"); // DEBUG
}
