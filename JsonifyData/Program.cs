using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using JsonifyData;








List<Planet> planets = new List<Planet>()
        {
            new Planet
            {
                Name="Earth",
                Distance_from_sun = 150000000,
                Diameter= 12756,
                Age=4500000000,
                Rotation_period=1440,
                Rotation_speed=1670,
                Orbital_period=365,
                Moons=1,
                Mass="5972 * 1024 kg",
                Highest_temp=56.7,
                Lowest_temp=-89.2,
                Statements={
                    "Earth only has one moon.",
                    "Earth is more than 4.5 billion years old.",
                    "Earth takes a year to orbitate one round of the Sun.",
                    "Earth rotates around its own axis in 24 hours.",
                    "Earth is filled by: 71% of water, the rest are land.",
                    "Humans are only on Earth (yet), and they emerged ca. 300 000 years ago. Nowadays, the human population is around 8 billion already.",
                    "Every fourth year, we have to add an extra day, now containing 366 days, it's called &#34;Leap year&#34;.",
                },
                 Quests={
                    new QuestionAndAnswer{
                        Question="How many moons does Earth have? (3, 7, 1, 4)",
                        Answers={ "3", "7", "1", "4" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="How old is Earth? (100 thousand years, 6 million years, 4.5 billion years, 10 billion years)",
                        Answers={ "100 thousand years", "6 million years", "4.5 billion years", "10 billion years" },
                        CorrectAnswerIndex =2
                    },
                    new QuestionAndAnswer{
                        Question="What does the earth consist of?",
                        Answers={ "71% water and 29% land", "29% water and 71% water", "50% water and 50% land", "85% water and 15% land" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="How long does the Earth need to rotate around its own axis?",
                        Answers={ "12 hours", "6 hours", "24 hours", "48 hours" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="How long does it take the Earth to orbitate one round of the Sun?",
                        Answers={ "Half a year", "1 year", "5 years", "6 Months" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="How many days are there in a year on earth?",
                        Answers={ "365 days", "366 days", "256 days", "460 days" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="For how many years, have there been humans on earth?",
                        Answers={ "100.000", "10.000", "600.000", "300.000" },
                        CorrectAnswerIndex=3
                    }, 
                    new QuestionAndAnswer{
                        Question="What does the &#34;Leap Year&#34; mean?",
                        Answers={ "When we have one less day", "When we have one extra day", "When we have one extra month", "When we have two less months" },
                        CorrectAnswerIndex=1
                    },    
                    new QuestionAndAnswer{
                        Question="How big is the human population on Earth?",
                        Answers={ "4 million", "100.000", "8 billion", "16.000" },
                        CorrectAnswerIndex=2
                    },

                }
            },
        };

Console.WriteLine($"{JsonSerializer.Serialize(planets)}");
Console.ReadKey();


