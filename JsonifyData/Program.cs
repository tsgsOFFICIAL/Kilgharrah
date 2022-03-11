using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using JsonifyData;






#region English

List<Planet> planets_en = new List<Planet>()
        {
         /// <summary>
         /// Earth.
         /// </summary>
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
                Mass=5972*Math.Pow(10,24),
                Highest_temp=56.7,
                Lowest_temp=-89.2,
                Statements={
                    "Earth only has one moon.",
                    "Earth is more than 4.5 billion years old.",
                    "Earth takes a year to orbitate one round of the Sun.",
                    "Earth rotates around its own axis in 24 hours.",
                    "Earth is filled by: 71% of water, the rest are land.",
                    "Humans are only on Earth (yet), and they emerged ca. 300 000 years ago. Nowadays, the human population is around 8 billion already.",
                    "Every fourth year, we have to add an extra day, now containing 366 days, it's called &#34;Leap year&#34;."
                },
                 Quests={
                    new QuestionAndAnswer{
                        Question="How many moons does Earth have?",
                        Answers={ "3", "7", "1", "4" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="How old is Earth?",
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

         /// <summary>
         /// Mercury.
         /// </summary>
            new Planet
            {
                Name="Mercury",
                Distance_from_sun = 47000000,
                Diameter= 4878 ,
                Age=4600000000,
                Rotation_period=84450,
                Rotation_speed=10892 ,
                Orbital_period=88,
                Moons=0,
                Mass=3.301*Math.Pow(10,23),
                Highest_temp=430,
                Lowest_temp=-180,
                Statements={
                    "Mercury is one of the smallest planets in the Solar System, and it is the closest to the Sun",
                    "Mercury orbits around the Sun in 88 Days, the shortest of all the Sun's planets.",
                    "It is named after the Roman god of commerce, and the messenger of the gods, Mercurius.",
                    "It's surface appears heavily cratered and similar in appearance to the Moon's.",
                    "Despite the small size, Mercury has a significant, and apparently global magnetic field.",
                    "It has almost no atmosphere to retain heat, the temperature ranges from -173 °C to 427 °C.",
                    "The planet experienced a spacecraft crash, back in the 30 of April, 2015; when NASA intentionally let a spacecraft, named &#34;MESSENGER&#34; crash into it."
                },
                 Quests={
                    new QuestionAndAnswer{
                        Question="How long does it take Mercury to orbitate one round of the Sun?",
                        Answers={ "10 days", "88 days", "200 days", "365 days" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Who was the planet Mercury named after?",
                        Answers={ "It isn’t named after anybody", "The Greek god, Hermes", "The Roman god, Mercurius"},
                        CorrectAnswerIndex =2
                    },
                    new QuestionAndAnswer{
                        Question="What is the maximum temperature on Mercury?",
                        Answers={ "166 °C", "512 °C", "427 °C", "400 °C" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What is the minimum temperature on Mercury?",
                        Answers={ "-173 °C", "0 °C", "-100 °C", "-386 °C" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="What was the name of the space probe that NASA crashed on Mercury?",
                        Answers={ "MESSAGE", "MESSENGER", "MESSAGES", "MESS" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="What does the surface of the planet Mercury look like?",
                        Answers={ "Smooth", "Small Hills", "Heavily Cratered", "Covered by water" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that Mercury is the closest planet to the Sun?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex=0
                    },

                }
            },
         
         /// <summary>
         /// Venus.
         /// </summary>
            new Planet
            {
                Name="Venus",
                Distance_from_sun = 108208930 ,
                Diameter= 12104 ,
                Age=4600000000,
                Rotation_period=348480,
                Rotation_speed=6.52,
                Orbital_period=225 ,
                Moons=0,
                Mass=4867*Math.Pow(10,24),
                Highest_temp=475,
                Lowest_temp=-173,
                Statements={
                    "Venus is the second closest planet from the Sun.",
                    "It's named after the Roman goddess of love and beauty, Venus.",
                    "Venus orbits around the Sun in 225 days.",
                    "Venus is the brightest natural object in the sky, after the Moon, it can cast shadows and can be visible to the naked eye in broad daylight.",
                    "Like Mercury, Venus does not have any moons also.",
                    "Though Mercury is closer to the Sun, Venus has the hottest surface of any planet in the Solar System, with the max temperature around 474 °C.",
                    "It's size and mass are similar to the Earth, often described as &#34;Earth's sister&#34;.",
                    "It has an theory, which says out, that if Venus had any ocean or even water on it's land, it was evaporated by the heat, and because the lack of the magnetic field, the remaining free hydrogen was swept into interplanetary space by the solar wind."
                },
                 Quests={
                    new QuestionAndAnswer{
                        Question="What position does Venus have in the order of the planets when counting from the sun?",
                        Answers={ "First", "Fourth", "Second", "Tenth" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Which god or goddess was the planet named after?",
                        Answers={ "The roman goddess, Venus", "The roman goddess, Diana", "The greek goddess, Aphrodite", "The greek goddess, Artemis" },
                        CorrectAnswerIndex =0
                    },
                    new QuestionAndAnswer{
                        Question="How long does it take Venus to orbitate one round of the Sun?",
                        Answers={ "112 days", "225 days", "256 days", "720 days" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="How many moons does Venus have?",
                        Answers={ "2", "7", "0", "6" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What is the maximum temperature on Venus?",
                        Answers={ "1000 °C", "600 °C", "474 °C", "200 °C" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that Venus is one of the brightest natural objects in the Solar System?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Why can we call Venus, as &#34;Earth's sister&#34;?",
                        Answers={ "Because of Size and Mass are similar to Earth", "There aren't such a thing like &#34;Earth's sister&#34;"},
                        CorrectAnswerIndex=0
                    }
                 }
            },

         /// <summary>
         /// Mars.
         /// </summary>
            new Planet
            {
                Name = "Mars",
                Distance_from_sun = 228000000,
                Diameter = 6792,
                Age = 3000000000,
                Rotation_period = 1476,
                Rotation_speed = 868.22,
                Orbital_period = 687,
                Moons = 2,
                Mass = 6417 * Math.Pow(10, 23),
                Highest_temp = 21,
                Lowest_temp = -128,
                Statements ={
                    "Mars is the second-smallest planet in the Solar System and the fourth planet of the Sun.",
                    "It's named after the Roman god of war, Mars.",
                    "The planet has two moons, Phobos and Demios.",
                    "It has a thin atmosphere, with the surface featuring impact craters, valleys, dunes, and polar ice caps.",
                    "Mars has the largest volcano and the highest known mountain in the Solar System, named Olympus Mons.",
                    "The planet was visited by several uncrewed spacecraft, for ex.: &#34;Mariner 4, in 1965&#34;",
                    "It can easily be seen from Earth with naked eye."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="What position does Mars have in the order of the planets when counting from the sun?",
                        Answers={ "Fourth", "second", "sixth", "ninth" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that Mars is the second smallest planet in the Solar System?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex =0
                    },
                    new QuestionAndAnswer{
                        Question="What was Mars the god of?",
                        Answers={ "Flowers", "Life", "War", "Death" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="We know Mars has two moons. What are they called?",
                        Answers={ "Triton and Titan", "Callisto and Europa", "Phobos and Deimos"},
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What is the name of the highest known mountain on Mars?",
                        Answers={ "It hasn’t got any name", "Olympia Moon", "Olympus Mons", "Olympian Field" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that the planet was visited by several CREWED spacecrafts?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that you can see the planet with naked eye from the Earth?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Does Mars have any kind of atmosphere?",
                        Answers={ "Thin", "Strong", "Weak", "Tall" },
                        CorrectAnswerIndex=0
                    }
                }
            },
         
         /// <summary>
         /// Jupiter.
         /// </summary>
            new Planet
            {
                Name = "Jupiter",
                Distance_from_sun = 778000000,
                Diameter = 143000,
                Age = 4600000000,
                Rotation_period = 595,
                Rotation_speed = 45000,
                Orbital_period = 4333,
                Moons = 81,
                Mass = 1898 * Math.Pow(10, 27),
                Highest_temp = 145,
                Lowest_temp = -195,
                Statements ={
                    "Jupiter is the fifth planet from the Sun, and the largest in the Solar System.",
                    "It's named after the roman god Jupiter, the king of the gods.",
                    "The planet completes an orbit around the Sun every 11.86 years.",
                    "Jupiter is the third brightest natural object in the Earth's night sky, after the Moon and Venus.",
                    "The planet is primarily composed of hydrogen and helium, it lacks a well-defined solid surface.",
                    "Jupiter has at least 80 known moons and possibly many more, the four biggest are: Io, Europa, Ganymede and Callisto.",
                    "People have been observing Jupiter since prehistoric times."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="What position does Jupitor have in the order of the planets when counting from the sun?",
                        Answers={ "Fifth", "First", "Sixth", "Seventh" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="What was Jupiter the god of?",
                        Answers={ "The god of the underworld, Hades", "The roman king of the gods, Jupiter", "the goddess of magic, Hecate"},
                        CorrectAnswerIndex =1
                    },
                    new QuestionAndAnswer{
                        Question="How long does it take Jupiter to orbitate one round of the Sun?",
                        Answers={ "Around 22 Years", "Around 600 days", "Around 12 year", "Around 15 years" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="How many moons does Jupiter have?",
                        Answers={ "Ca. 20 moons", "Ca. 45 moons", "Ca. 70 moons", "Ca. 80 moons" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="Since when did humans start to observe the planet?",
                        Answers={ "Since yesterday", "Since last year", "Since prehistoric times", "Since last week" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What is the planet composed of?",
                        Answers={ "Solid surface", "Hydrogen and Helium", "water"},
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="What are the four biggest Moon called?",
                        Answers={ "Io, Callisto, Europa, and Ganymede", "Jupiter, Fo, Callisteo, and Phobos", "Miraculus, Saturn, Ganymede, and Quasimodo"},
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that Jupiter is the biggest planet in the Solar System?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex=0
                    }
                }
            },
         
         /// <summary>
         /// Saturn.
         /// </summary>
            new Planet
            {
                Name = "Saturn",
                Distance_from_sun = 1433449370,
                Diameter = 120500,
                Age = 4600000000,
                Rotation_period = 642,
                Rotation_speed = 35500,
                Orbital_period = 10756,
                Moons = 82,
                Mass = 5683 * Math.Pow(10, 26),
                Highest_temp = 57,
                Lowest_temp = -173,
                Statements ={
                    "Saturn is the sixth planet from the Sun and the second-largest in the Solar System.",
                    "It takes Saturn 10 759 days to finish one revolution around the Sun.",
                    "The outer atmosphere is generally bland and lacking in contrast, although long-lived features can appear.",
                    "Wind speeds on the planet can reach 1800 km/h.",
                    "Saturn's most notable feature is it's prominent ring system, which is composed mainly of ice particles, with a smaller amount of rocky debris and dust.",
                    "Saturn has at least 83 moons of which 53 are officially named, the largest one called &#34;Titan&#34;.",
                    "It's named after the roman god of wealth and agriculture and the father of Jupiter, Saturn."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="What position does Saturn have in the order of the planets when counting from the sun?",
                        Answers={ "First", "Fifth", "Tenth", "Sixth" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that it takes 10759 days for Saturn to orbitate one round of the Sun?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex =0
                    },
                    new QuestionAndAnswer{
                        Question="How many moons does Saturn have?",
                        Answers={ "53", "36", "83", "92" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What are the highest measured wind speeds on the planet?",
                        Answers={ "100km/h", "1800km/h", "320km/h", "960km/h"},
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that Saturn is the third largest planet in the Solar System?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Who is the planet named after?",
                        Answers={ "The greek god of titans, Cronus", "The roman god of wealth and agriculture, Saturn", "The greek goddess of snow, Khione", "The norse god of lightnings, Thor" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="What does Saturn have that no other planet has?",
                        Answers={ "A system of rings in orbit", "A special brand of candy", "A high-speed train"},
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="What is the largest moon of Saturn, called?",
                        Answers={ "Ghost", "Titan", "Zeus", "Giant" },
                        CorrectAnswerIndex=1
                    }
                }
            },
         
         /// <summary>
         /// Uranus.
         /// </summary>
            new Planet
            {
                Name = "Uranus",
                Distance_from_sun = 2870972200,
                Diameter = 51100,
                Age = 4600000000,
                Rotation_period = 1020,
                Rotation_speed = 9320,
                Orbital_period = 30687,
                Moons = 27,
                Mass = 8682 * Math.Pow(10, 25),
                Highest_temp = 4982,
                Lowest_temp = -224,
                Statements ={
                    "Uranus is the seventh planet of the Solarsystem.",
                    "It's named after the Greek god of the Sky, Uranus.",
                    "the planet orbits the Sun every 84 years.",
                    "Like Jupiter, it lacks a well-defined solid surface.",
                    "The planet's atmosphere is similar to Jupiter's and Saturn's in its primary composition of hydrogen and helium, but it contains more &#34;ices&#34;, such as water, or ex: ammonia.",
                    " Uranus has the coldest planetary atmosphere in the Solar System, with the minimum temperature of -224 °C",
                    "Wind speeds can reach 900 km/h.",
                    "The planet has 27 known moons.",
                    "Only one spacecraft visited the planet, in 1986, the &#34;Voyeur 2&#34;."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="What position does Uranus have in the order of the planets when counting from the sun?",
                        Answers={ "Third", "Seventh", "Fourth", "Eleventh" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="How long does it take Uranus to orbitate one round of the Sun?",
                        Answers={ "84 years", "105 years", "140 years", "56 years" },
                        CorrectAnswerIndex =0
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that Uranus doesn't have any solid material on the surface?",
                        Answers={ "Yes", "No" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Which planets can Uranus be compared to?",
                        Answers={ "Neptune and Mercury", "Mars and Venus", "Earth and Moon", "Jupiter and Saturn" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that Uranus has the coldest planetary atmosphere in the Solar System?",
                        Answers={ "Yes", "No" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Who is the planet named after?",
                        Answers={ "The greek god of the sky, Uranus", "The irish goddess of fate, Morrigan", "It wasn’t named after anybody" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="How many spacecraft has visited the planet?",
                        Answers={ "2", "5", "1", "10" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What are the highest measured wind speeds on the planet Uranus?",
                        Answers={ "450 km/h", "900 km/h", "500 km/h", "700 km/h" },
                        CorrectAnswerIndex=1
                    }
                }
            },

         /// <summary>
         /// Neptune.
         /// </summary>
            new Planet
            {
                Name = "Neptune",
                Distance_from_sun = 4503443661,
                Diameter = 49500,
                Age = 4600000000,
                Rotation_period = 960,
                Rotation_speed = 9650,
                Orbital_period = 60190,
                Moons = 14,
                Mass = 1024 * Math.Pow(10, 26),
                Highest_temp = 7000,
                Lowest_temp = -218,
                Statements ={
                    "Neptune is the eighth and the planet furthest from the Sun.",
                    "It has no well-defined solid surface, as being composed primarily of gasses and liquids.",
                    "The planet orbits the Sun every 165 years.",
                    "It's named after the roman god of the seas, Neptune.",
                    "Neptune has 14 known moons, the largest called Triton.",
                    "The planet's atmosphere is composed primarily of hydrogen and helium, along with traces of hydrocarbons and possibly nitrogen, though it contains more &#34;ices&#34;, than Jupiter or Saturn.",
                    "Like Uranus, only one spacecraft visited the planet, in 1989, &#34;The Voyeur 2&#34;.",
                    "Neptune's outer atmosphere is one of the coldest places in the Solar System, with the temperature around -218 °C, but at the planet's center is much hotter, notedly 5100 °C."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="Is it true that Neptune is the planet furthest from the Sun?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="How long does it take Neptune to orbitate one round of the Sun?",
                        Answers={ "200 years", "172 years", "165 years", "147 years" },
                        CorrectAnswerIndex =2
                    },
                    new QuestionAndAnswer{
                        Question="Who is the planet named after?",
                        Answers={ "The greek god of the seas, Poseidon", "The roman god of the seas, Neptune", "The egyptian god of the seas, Nu)" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="How many moons does Neptune have?",
                        Answers={ "10", "16", "14", "17" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What is the biggest moon in orbit of Neptune called?",
                        Answers={ "Triton", "Oceanus", "Styx", "Nereus" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that the planet has been visited by a lot of spacecrafts?",
                        Answers={ "Yes", "No" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="What is the temperature of Neptune's outer atmosphere?",
                        Answers={ "-162 °C", "-346 °C", "-218 °C", "-252 °C" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What is the temperature in the center Neptune's inner core?",
                        Answers={ "3700 °C", "4600 °C", "6600 °C", "5100 °C" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="What was the name of the spacecraft that visited Neptune?",
                        Answers={ "Voyeur 2", "MESSENGER", "Apollo 7", "It wasn’t named" },
                        CorrectAnswerIndex=0
                    },
                }
            },

         /// <summary>
         /// Pluto.
         /// </summary>
            new Planet
            {
                Name = "Pluto",
                Distance_from_sun = 5906376272,
                Diameter = 2274,
                Age = 4600000000,
                Rotation_period = 9180,
                Rotation_speed = 47.18,
                Orbital_period = 90520,
                Moons = 5,
                Mass = 1309 * Math.Pow(10, 22),
                Highest_temp = -223,
                Lowest_temp = -233,
                Statements ={
                    "Pluto is a dwarf planet in the Kuiper belt.",
                    "After the planet was discovered in 1930, it was declared to be the ninth planet from the Sun. Later this was questioned because of the distance and size, and this led to 2006, when it was reclassified as a dwarf planet.",
                    "It has 5 known moons: Charon, Styx, Nix, Kerberos and Hydra.",
                    "Back in 2015, a spacecraft, named &#34;New Horizons&#34; performed a flyby on Pluto, and it was the only visit to the planet.",
                    "Pluto orbits the Sun every 248 years.",
                    "The surface of Pluto is composed of more than 98% nitrogen ice, with traces of methane and carbon monoxide."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="Who is the planet named after?",
                        Answers={ "The norse goddess of death, Hela", "The greek god of the underworld, Hades", "The greek god of death, Thanatos", "The roman god of the underworld, Pluto" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question=" Is Pluto a normal planet?",
                        Answers={ "Yes", "no, It doesn’t exist", "It is unknown", "It is a dwarf planet" },
                        CorrectAnswerIndex =3
                    },
                    new QuestionAndAnswer{
                        Question="When was Pluto discovered by humans?",
                        Answers={ "1890", "1910", "1930", "1950" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="How long does it take Pluto to orbitate one round of the Sun??",
                        Answers={ "248 days", "248 months", "248 years" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="How many moons does Pluto have?",
                        Answers={ "15", "22", "5", "10" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What year was Pluto visited by a spacecraft?",
                        Answers={ "2006", "2012", "2009", "2015" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="What was the name of the spacecraft that visited the planet?",
                        Answers={ "New Horizons", "Voyeur 5", "Titanic 22", "Crazy Horse" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="What is Pluto composed of?",
                        Answers={ "Dirt", "Sugar", "Nitrogen Ice", "Salt", "Grass" },
                        CorrectAnswerIndex=2
                    }
                }
            },
        };

#endregion




#region Danish

List<Planet> planets_da = new List<Planet>()
        {
         /// <summary>
         /// Earth.
         /// </summary>
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
                Mass=5972*Math.Pow(10,24),
                Highest_temp=56.7,
                Lowest_temp=-89.2,
                Statements={
                    "Earth only has one moon.",
                    "Earth is more than 4.5 billion years old.",
                    "Earth takes a year to orbitate one round of the Sun.",
                    "Earth rotates around its own axis in 24 hours.",
                    "Earth is filled by: 71% of water, the rest are land.",
                    "Humans are only on Earth (yet), and they emerged ca. 300 000 years ago. Nowadays, the human population is around 8 billion already.",
                    "Every fourth year, we have to add an extra day, now containing 366 days, it's called &#34;Leap year&#34;."
                },
                 Quests={
                    new QuestionAndAnswer{
                        Question="How many moons does Earth have?",
                        Answers={ "3", "7", "1", "4" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="How old is Earth?",
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

         /// <summary>
         /// Mercury.
         /// </summary>
            new Planet
            {
                Name="Mercury",
                Distance_from_sun = 47000000,
                Diameter= 4878 ,
                Age=4600000000,
                Rotation_period=84450,
                Rotation_speed=10892 ,
                Orbital_period=88,
                Moons=0,
                Mass=3.301*Math.Pow(10,23),
                Highest_temp=430,
                Lowest_temp=-180,
                Statements={
                    "Mercury is one of the smallest planets in the Solar System, and it is the closest to the Sun",
                    "Mercury orbits around the Sun in 88 Days, the shortest of all the Sun's planets.",
                    "It is named after the Roman god of commerce, and the messenger of the gods, Mercurius.",
                    "It's surface appears heavily cratered and similar in appearance to the Moon's.",
                    "Despite the small size, Mercury has a significant, and apparently global magnetic field.",
                    "It has almost no atmosphere to retain heat, the temperature ranges from -173 °C to 427 °C.",
                    "The planet experienced a spacecraft crash, back in the 30 of April, 2015; when NASA intentionally let a spacecraft, named &#34;MESSENGER&#34; crash into it."
                },
                 Quests={
                    new QuestionAndAnswer{
                        Question="How long does it take Mercury to orbitate one round of the Sun?",
                        Answers={ "10 days", "88 days", "200 days", "365 days" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Who was the planet Mercury named after?",
                        Answers={ "It isn’t named after anybody", "The Greek god, Hermes", "The Roman god, Mercurius"},
                        CorrectAnswerIndex =2
                    },
                    new QuestionAndAnswer{
                        Question="What is the maximum temperature on Mercury?",
                        Answers={ "166 °C", "512 °C", "427 °C", "400 °C" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What is the minimum temperature on Mercury?",
                        Answers={ "-173 °C", "0 °C", "-100 °C", "-386 °C" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="What was the name of the space probe that NASA crashed on Mercury?",
                        Answers={ "MESSAGE", "MESSENGER", "MESSAGES", "MESS" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="What does the surface of the planet Mercury look like?",
                        Answers={ "Smooth", "Small Hills", "Heavily Cratered", "Covered by water" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that Mercury is the closest planet to the Sun?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex=0
                    },

                }
            },
         
         /// <summary>
         /// Venus.
         /// </summary>
            new Planet
            {
                Name="Venus",
                Distance_from_sun = 108208930 ,
                Diameter= 12104 ,
                Age=4600000000,
                Rotation_period=348480,
                Rotation_speed=6.52,
                Orbital_period=225 ,
                Moons=0,
                Mass=4867*Math.Pow(10,24),
                Highest_temp=475,
                Lowest_temp=-173,
                Statements={
                    "Venus is the second closest planet from the Sun.",
                    "It's named after the Roman goddess of love and beauty, Venus.",
                    "Venus orbits around the Sun in 225 days.",
                    "Venus is the brightest natural object in the sky, after the Moon, it can cast shadows and can be visible to the naked eye in broad daylight.",
                    "Like Mercury, Venus does not have any moons also.",
                    "Though Mercury is closer to the Sun, Venus has the hottest surface of any planet in the Solar System, with the max temperature around 474 °C.",
                    "It's size and mass are similar to the Earth, often described as &#34;Earth's sister&#34;.",
                    "It has an theory, which says out, that if Venus had any ocean or even water on it's land, it was evaporated by the heat, and because the lack of the magnetic field, the remaining free hydrogen was swept into interplanetary space by the solar wind."
                },
                 Quests={
                    new QuestionAndAnswer{
                        Question="What position does Venus have in the order of the planets when counting from the sun?",
                        Answers={ "First", "Fourth", "Second", "Tenth" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Which god or goddess was the planet named after?",
                        Answers={ "The roman goddess, Venus", "The roman goddess, Diana", "The greek goddess, Aphrodite", "The greek goddess, Artemis" },
                        CorrectAnswerIndex =0
                    },
                    new QuestionAndAnswer{
                        Question="How long does it take Venus to orbitate one round of the Sun?",
                        Answers={ "112 days", "225 days", "256 days", "720 days" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="How many moons does Venus have?",
                        Answers={ "2", "7", "0", "6" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What is the maximum temperature on Venus?",
                        Answers={ "1000 °C", "600 °C", "474 °C", "200 °C" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that Venus is one of the brightest natural objects in the Solar System?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Why can we call Venus, as &#34;Earth's sister&#34;?",
                        Answers={ "Because of Size and Mass are similar to Earth", "There aren't such a thing like &#34;Earth's sister&#34;"},
                        CorrectAnswerIndex=0
                    }
                 }
            },

         /// <summary>
         /// Mars.
         /// </summary>
            new Planet
            {
                Name = "Mars",
                Distance_from_sun = 228000000,
                Diameter = 6792,
                Age = 3000000000,
                Rotation_period = 1476,
                Rotation_speed = 868.22,
                Orbital_period = 687,
                Moons = 2,
                Mass = 6417 * Math.Pow(10, 23),
                Highest_temp = 21,
                Lowest_temp = -128,
                Statements ={
                    "Mars is the second-smallest planet in the Solar System and the fourth planet of the Sun.",
                    "It's named after the Roman god of war, Mars.",
                    "The planet has two moons, Phobos and Demios.",
                    "It has a thin atmosphere, with the surface featuring impact craters, valleys, dunes, and polar ice caps.",
                    "Mars has the largest volcano and the highest known mountain in the Solar System, named Olympus Mons.",
                    "The planet was visited by several uncrewed spacecraft, for ex.: &#34;Mariner 4, in 1965&#34;",
                    "It can easily be seen from Earth with naked eye."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="What position does Mars have in the order of the planets when counting from the sun?",
                        Answers={ "Fourth", "second", "sixth", "ninth" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that Mars is the second smallest planet in the Solar System?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex =0
                    },
                    new QuestionAndAnswer{
                        Question="What was Mars the god of?",
                        Answers={ "Flowers", "Life", "War", "Death" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="We know Mars has two moons. What are they called?",
                        Answers={ "Triton and Titan", "Callisto and Europa", "Phobos and Deimos"},
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What is the name of the highest known mountain on Mars?",
                        Answers={ "It hasn’t got any name", "Olympia Moon", "Olympus Mons", "Olympian Field" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that the planet was visited by several CREWED spacecrafts?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that you can see the planet with naked eye from the Earth?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Does Mars have any kind of atmosphere?",
                        Answers={ "Thin", "Strong", "Weak", "Tall" },
                        CorrectAnswerIndex=0
                    }
                }
            },
         
         /// <summary>
         /// Jupiter.
         /// </summary>
            new Planet
            {
                Name = "Jupiter",
                Distance_from_sun = 778000000,
                Diameter = 143000,
                Age = 4600000000,
                Rotation_period = 595,
                Rotation_speed = 45000,
                Orbital_period = 4333,
                Moons = 81,
                Mass = 1898 * Math.Pow(10, 27),
                Highest_temp = 145,
                Lowest_temp = -195,
                Statements ={
                    "Jupiter is the fifth planet from the Sun, and the largest in the Solar System.",
                    "It's named after the roman god Jupiter, the king of the gods.",
                    "The planet completes an orbit around the Sun every 11.86 years.",
                    "Jupiter is the third brightest natural object in the Earth's night sky, after the Moon and Venus.",
                    "The planet is primarily composed of hydrogen and helium, it lacks a well-defined solid surface.",
                    "Jupiter has at least 80 known moons and possibly many more, the four biggest are: Io, Europa, Ganymede and Callisto.",
                    "People have been observing Jupiter since prehistoric times."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="What position does Jupitor have in the order of the planets when counting from the sun?",
                        Answers={ "Fifth", "First", "Sixth", "Seventh" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="What was Jupiter the god of?",
                        Answers={ "The god of the underworld, Hades", "The roman king of the gods, Jupiter", "the goddess of magic, Hecate"},
                        CorrectAnswerIndex =1
                    },
                    new QuestionAndAnswer{
                        Question="How long does it take Jupiter to orbitate one round of the Sun?",
                        Answers={ "Around 22 Years", "Around 600 days", "Around 12 year", "Around 15 years" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="How many moons does Jupiter have?",
                        Answers={ "Ca. 20 moons", "Ca. 45 moons", "Ca. 70 moons", "Ca. 80 moons" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="Since when did humans start to observe the planet?",
                        Answers={ "Since yesterday", "Since last year", "Since prehistoric times", "Since last week" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What is the planet composed of?",
                        Answers={ "Solid surface", "Hydrogen and Helium", "water"},
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="What are the four biggest Moon called?",
                        Answers={ "Io, Callisto, Europa, and Ganymede", "Jupiter, Fo, Callisteo, and Phobos", "Miraculus, Saturn, Ganymede, and Quasimodo"},
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that Jupiter is the biggest planet in the Solar System?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex=0
                    }
                }
            },
         
         /// <summary>
         /// Saturn.
         /// </summary>
            new Planet
            {
                Name = "Saturn",
                Distance_from_sun = 1433449370,
                Diameter = 120500,
                Age = 4600000000,
                Rotation_period = 642,
                Rotation_speed = 35500,
                Orbital_period = 10756,
                Moons = 82,
                Mass = 5683 * Math.Pow(10, 26),
                Highest_temp = 57,
                Lowest_temp = -173,
                Statements ={
                    "Saturn is the sixth planet from the Sun and the second-largest in the Solar System.",
                    "It takes Saturn 10 759 days to finish one revolution around the Sun.",
                    "The outer atmosphere is generally bland and lacking in contrast, although long-lived features can appear.",
                    "Wind speeds on the planet can reach 1800 km/h.",
                    "Saturn's most notable feature is it's prominent ring system, which is composed mainly of ice particles, with a smaller amount of rocky debris and dust.",
                    "Saturn has at least 83 moons of which 53 are officially named, the largest one called &#34;Titan&#34;.",
                    "It's named after the roman god of wealth and agriculture and the father of Jupiter, Saturn."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="What position does Saturn have in the order of the planets when counting from the sun?",
                        Answers={ "First", "Fifth", "Tenth", "Sixth" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that it takes 10759 days for Saturn to orbitate one round of the Sun?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex =0
                    },
                    new QuestionAndAnswer{
                        Question="How many moons does Saturn have?",
                        Answers={ "53", "36", "83", "92" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What are the highest measured wind speeds on the planet?",
                        Answers={ "100km/h", "1800km/h", "320km/h", "960km/h"},
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that Saturn is the third largest planet in the Solar System?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Who is the planet named after?",
                        Answers={ "The greek god of titans, Cronus", "The roman god of wealth and agriculture, Saturn", "The greek goddess of snow, Khione", "The norse god of lightnings, Thor" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="What does Saturn have that no other planet has?",
                        Answers={ "A system of rings in orbit", "A special brand of candy", "A high-speed train"},
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="What is the largest moon of Saturn, called?",
                        Answers={ "Ghost", "Titan", "Zeus", "Giant" },
                        CorrectAnswerIndex=1
                    }
                }
            },
         
         /// <summary>
         /// Uranus.
         /// </summary>
            new Planet
            {
                Name = "Uranus",
                Distance_from_sun = 2870972200,
                Diameter = 51100,
                Age = 4600000000,
                Rotation_period = 1020,
                Rotation_speed = 9320,
                Orbital_period = 30687,
                Moons = 27,
                Mass = 8682 * Math.Pow(10, 25),
                Highest_temp = 4982,
                Lowest_temp = -224,
                Statements ={
                    "Uranus is the seventh planet of the Solarsystem.",
                    "It's named after the Greek god of the Sky, Uranus.",
                    "the planet orbits the Sun every 84 years.",
                    "Like Jupiter, it lacks a well-defined solid surface.",
                    "The planet's atmosphere is similar to Jupiter's and Saturn's in its primary composition of hydrogen and helium, but it contains more &#34;ices&#34;, such as water, or ex: ammonia.",
                    " Uranus has the coldest planetary atmosphere in the Solar System, with the minimum temperature of -224 °C",
                    "Wind speeds can reach 900 km/h.",
                    "The planet has 27 known moons.",
                    "Only one spacecraft visited the planet, in 1986, the &#34;Voyeur 2&#34;."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="What position does Uranus have in the order of the planets when counting from the sun?",
                        Answers={ "Third", "Seventh", "Fourth", "Eleventh" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="How long does it take Uranus to orbitate one round of the Sun?",
                        Answers={ "84 years", "105 years", "140 years", "56 years" },
                        CorrectAnswerIndex =0
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that Uranus doesn't have any solid material on the surface?",
                        Answers={ "Yes", "No" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Which planets can Uranus be compared to?",
                        Answers={ "Neptune and Mercury", "Mars and Venus", "Earth and Moon", "Jupiter and Saturn" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that Uranus has the coldest planetary atmosphere in the Solar System?",
                        Answers={ "Yes", "No" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Who is the planet named after?",
                        Answers={ "The greek god of the sky, Uranus", "The irish goddess of fate, Morrigan", "It wasn’t named after anybody" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="How many spacecraft has visited the planet?",
                        Answers={ "2", "5", "1", "10" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What are the highest measured wind speeds on the planet Uranus?",
                        Answers={ "450 km/h", "900 km/h", "500 km/h", "700 km/h" },
                        CorrectAnswerIndex=1
                    }
                }
            },

         /// <summary>
         /// Neptune.
         /// </summary>
            new Planet
            {
                Name = "Neptune",
                Distance_from_sun = 4503443661,
                Diameter = 49500,
                Age = 4600000000,
                Rotation_period = 960,
                Rotation_speed = 9650,
                Orbital_period = 60190,
                Moons = 14,
                Mass = 1024 * Math.Pow(10, 26),
                Highest_temp = 7000,
                Lowest_temp = -218,
                Statements ={
                    "Neptune is the eighth and the planet furthest from the Sun.",
                    "It has no well-defined solid surface, as being composed primarily of gasses and liquids.",
                    "The planet orbits the Sun every 165 years.",
                    "It's named after the roman god of the seas, Neptune.",
                    "Neptune has 14 known moons, the largest called Triton.",
                    "The planet's atmosphere is composed primarily of hydrogen and helium, along with traces of hydrocarbons and possibly nitrogen, though it contains more &#34;ices&#34;, than Jupiter or Saturn.",
                    "Like Uranus, only one spacecraft visited the planet, in 1989, &#34;The Voyeur 2&#34;.",
                    "Neptune's outer atmosphere is one of the coldest places in the Solar System, with the temperature around -218 °C, but at the planet's center is much hotter, notedly 5100 °C."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="Is it true that Neptune is the planet furthest from the Sun?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="How long does it take Neptune to orbitate one round of the Sun?",
                        Answers={ "200 years", "172 years", "165 years", "147 years" },
                        CorrectAnswerIndex =2
                    },
                    new QuestionAndAnswer{
                        Question="Who is the planet named after?",
                        Answers={ "The greek god of the seas, Poseidon", "The roman god of the seas, Neptune", "The egyptian god of the seas, Nu)" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="How many moons does Neptune have?",
                        Answers={ "10", "16", "14", "17" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What is the biggest moon in orbit of Neptune called?",
                        Answers={ "Triton", "Oceanus", "Styx", "Nereus" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that the planet has been visited by a lot of spacecrafts?",
                        Answers={ "Yes", "No" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="What is the temperature of Neptune's outer atmosphere?",
                        Answers={ "-162 °C", "-346 °C", "-218 °C", "-252 °C" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What is the temperature in the center Neptune's inner core?",
                        Answers={ "3700 °C", "4600 °C", "6600 °C", "5100 °C" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="What was the name of the spacecraft that visited Neptune?",
                        Answers={ "Voyeur 2", "MESSENGER", "Apollo 7", "It wasn’t named" },
                        CorrectAnswerIndex=0
                    },
                }
            },

         /// <summary>
         /// Pluto.
         /// </summary>
            new Planet
            {
                Name = "Pluto",
                Distance_from_sun = 5906376272,
                Diameter = 2274,
                Age = 4600000000,
                Rotation_period = 9180,
                Rotation_speed = 47.18,
                Orbital_period = 90520,
                Moons = 5,
                Mass = 1309 * Math.Pow(10, 22),
                Highest_temp = -223,
                Lowest_temp = -233,
                Statements ={
                    "Pluto is a dwarf planet in the Kuiper belt.",
                    "After the planet was discovered in 1930, it was declared to be the ninth planet from the Sun. Later this was questioned because of the distance and size, and this led to 2006, when it was reclassified as a dwarf planet.",
                    "It has 5 known moons: Charon, Styx, Nix, Kerberos and Hydra.",
                    "Back in 2015, a spacecraft, named &#34;New Horizons&#34; performed a flyby on Pluto, and it was the only visit to the planet.",
                    "Pluto orbits the Sun every 248 years.",
                    "The surface of Pluto is composed of more than 98% nitrogen ice, with traces of methane and carbon monoxide."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="Who is the planet named after?",
                        Answers={ "The norse goddess of death, Hela", "The greek god of the underworld, Hades", "The greek god of death, Thanatos", "The roman god of the underworld, Pluto" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question=" Is Pluto a normal planet?",
                        Answers={ "Yes", "no, It doesn’t exist", "It is unknown", "It is a dwarf planet" },
                        CorrectAnswerIndex =3
                    },
                    new QuestionAndAnswer{
                        Question="When was Pluto discovered by humans?",
                        Answers={ "1890", "1910", "1930", "1950" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="How long does it take Pluto to orbitate one round of the Sun??",
                        Answers={ "248 days", "248 months", "248 years" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="How many moons does Pluto have?",
                        Answers={ "15", "22", "5", "10" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What year was Pluto visited by a spacecraft?",
                        Answers={ "2006", "2012", "2009", "2015" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="What was the name of the spacecraft that visited the planet?",
                        Answers={ "New Horizons", "Voyeur 5", "Titanic 22", "Crazy Horse" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="What is Pluto composed of?",
                        Answers={ "Dirt", "Sugar", "Nitrogen Ice", "Salt", "Grass" },
                        CorrectAnswerIndex=2
                    }
                }
            },
        };

#endregion




#region Hungarian

List<Planet> planets_hu = new List<Planet>()
        {
         /// <summary>
         /// Earth.
         /// </summary>
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
                Mass=5972*Math.Pow(10,24),
                Highest_temp=56.7,
                Lowest_temp=-89.2,
                Statements={
                    "Earth only has one moon.",
                    "Earth is more than 4.5 billion years old.",
                    "Earth takes a year to orbitate one round of the Sun.",
                    "Earth rotates around its own axis in 24 hours.",
                    "Earth is filled by: 71% of water, the rest are land.",
                    "Humans are only on Earth (yet), and they emerged ca. 300 000 years ago. Nowadays, the human population is around 8 billion already.",
                    "Every fourth year, we have to add an extra day, now containing 366 days, it's called &#34;Leap year&#34;."
                },
                 Quests={
                    new QuestionAndAnswer{
                        Question="How many moons does Earth have?",
                        Answers={ "3", "7", "1", "4" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="How old is Earth?",
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

         /// <summary>
         /// Mercury.
         /// </summary>
            new Planet
            {
                Name="Mercury",
                Distance_from_sun = 47000000,
                Diameter= 4878 ,
                Age=4600000000,
                Rotation_period=84450,
                Rotation_speed=10892 ,
                Orbital_period=88,
                Moons=0,
                Mass=3.301*Math.Pow(10,23),
                Highest_temp=430,
                Lowest_temp=-180,
                Statements={
                    "Mercury is one of the smallest planets in the Solar System, and it is the closest to the Sun",
                    "Mercury orbits around the Sun in 88 Days, the shortest of all the Sun's planets.",
                    "It is named after the Roman god of commerce, and the messenger of the gods, Mercurius.",
                    "It's surface appears heavily cratered and similar in appearance to the Moon's.",
                    "Despite the small size, Mercury has a significant, and apparently global magnetic field.",
                    "It has almost no atmosphere to retain heat, the temperature ranges from -173 °C to 427 °C.",
                    "The planet experienced a spacecraft crash, back in the 30 of April, 2015; when NASA intentionally let a spacecraft, named &#34;MESSENGER&#34; crash into it."
                },
                 Quests={
                    new QuestionAndAnswer{
                        Question="How long does it take Mercury to orbitate one round of the Sun?",
                        Answers={ "10 days", "88 days", "200 days", "365 days" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Who was the planet Mercury named after?",
                        Answers={ "It isn’t named after anybody", "The Greek god, Hermes", "The Roman god, Mercurius"},
                        CorrectAnswerIndex =2
                    },
                    new QuestionAndAnswer{
                        Question="What is the maximum temperature on Mercury?",
                        Answers={ "166 °C", "512 °C", "427 °C", "400 °C" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What is the minimum temperature on Mercury?",
                        Answers={ "-173 °C", "0 °C", "-100 °C", "-386 °C" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="What was the name of the space probe that NASA crashed on Mercury?",
                        Answers={ "MESSAGE", "MESSENGER", "MESSAGES", "MESS" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="What does the surface of the planet Mercury look like?",
                        Answers={ "Smooth", "Small Hills", "Heavily Cratered", "Covered by water" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that Mercury is the closest planet to the Sun?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex=0
                    },

                }
            },
         
         /// <summary>
         /// Venus.
         /// </summary>
            new Planet
            {
                Name="Venus",
                Distance_from_sun = 108208930 ,
                Diameter= 12104 ,
                Age=4600000000,
                Rotation_period=348480,
                Rotation_speed=6.52,
                Orbital_period=225 ,
                Moons=0,
                Mass=4867*Math.Pow(10,24),
                Highest_temp=475,
                Lowest_temp=-173,
                Statements={
                    "Venus is the second closest planet from the Sun.",
                    "It's named after the Roman goddess of love and beauty, Venus.",
                    "Venus orbits around the Sun in 225 days.",
                    "Venus is the brightest natural object in the sky, after the Moon, it can cast shadows and can be visible to the naked eye in broad daylight.",
                    "Like Mercury, Venus does not have any moons also.",
                    "Though Mercury is closer to the Sun, Venus has the hottest surface of any planet in the Solar System, with the max temperature around 474 °C.",
                    "It's size and mass are similar to the Earth, often described as &#34;Earth's sister&#34;.",
                    "It has an theory, which says out, that if Venus had any ocean or even water on it's land, it was evaporated by the heat, and because the lack of the magnetic field, the remaining free hydrogen was swept into interplanetary space by the solar wind."
                },
                 Quests={
                    new QuestionAndAnswer{
                        Question="What position does Venus have in the order of the planets when counting from the sun?",
                        Answers={ "First", "Fourth", "Second", "Tenth" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Which god or goddess was the planet named after?",
                        Answers={ "The roman goddess, Venus", "The roman goddess, Diana", "The greek goddess, Aphrodite", "The greek goddess, Artemis" },
                        CorrectAnswerIndex =0
                    },
                    new QuestionAndAnswer{
                        Question="How long does it take Venus to orbitate one round of the Sun?",
                        Answers={ "112 days", "225 days", "256 days", "720 days" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="How many moons does Venus have?",
                        Answers={ "2", "7", "0", "6" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What is the maximum temperature on Venus?",
                        Answers={ "1000 °C", "600 °C", "474 °C", "200 °C" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that Venus is one of the brightest natural objects in the Solar System?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Why can we call Venus, as &#34;Earth's sister&#34;?",
                        Answers={ "Because of Size and Mass are similar to Earth", "There aren't such a thing like &#34;Earth's sister&#34;"},
                        CorrectAnswerIndex=0
                    }
                 }
            },

         /// <summary>
         /// Mars.
         /// </summary>
            new Planet
            {
                Name = "Mars",
                Distance_from_sun = 228000000,
                Diameter = 6792,
                Age = 3000000000,
                Rotation_period = 1476,
                Rotation_speed = 868.22,
                Orbital_period = 687,
                Moons = 2,
                Mass = 6417 * Math.Pow(10, 23),
                Highest_temp = 21,
                Lowest_temp = -128,
                Statements ={
                    "Mars is the second-smallest planet in the Solar System and the fourth planet of the Sun.",
                    "It's named after the Roman god of war, Mars.",
                    "The planet has two moons, Phobos and Demios.",
                    "It has a thin atmosphere, with the surface featuring impact craters, valleys, dunes, and polar ice caps.",
                    "Mars has the largest volcano and the highest known mountain in the Solar System, named Olympus Mons.",
                    "The planet was visited by several uncrewed spacecraft, for ex.: &#34;Mariner 4, in 1965&#34;",
                    "It can easily be seen from Earth with naked eye."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="What position does Mars have in the order of the planets when counting from the sun?",
                        Answers={ "Fourth", "second", "sixth", "ninth" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that Mars is the second smallest planet in the Solar System?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex =0
                    },
                    new QuestionAndAnswer{
                        Question="What was Mars the god of?",
                        Answers={ "Flowers", "Life", "War", "Death" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="We know Mars has two moons. What are they called?",
                        Answers={ "Triton and Titan", "Callisto and Europa", "Phobos and Deimos"},
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What is the name of the highest known mountain on Mars?",
                        Answers={ "It hasn’t got any name", "Olympia Moon", "Olympus Mons", "Olympian Field" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that the planet was visited by several CREWED spacecrafts?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that you can see the planet with naked eye from the Earth?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Does Mars have any kind of atmosphere?",
                        Answers={ "Thin", "Strong", "Weak", "Tall" },
                        CorrectAnswerIndex=0
                    }
                }
            },
         
         /// <summary>
         /// Jupiter.
         /// </summary>
            new Planet
            {
                Name = "Jupiter",
                Distance_from_sun = 778000000,
                Diameter = 143000,
                Age = 4600000000,
                Rotation_period = 595,
                Rotation_speed = 45000,
                Orbital_period = 4333,
                Moons = 81,
                Mass = 1898 * Math.Pow(10, 27),
                Highest_temp = 145,
                Lowest_temp = -195,
                Statements ={
                    "Jupiter is the fifth planet from the Sun, and the largest in the Solar System.",
                    "It's named after the roman god Jupiter, the king of the gods.",
                    "The planet completes an orbit around the Sun every 11.86 years.",
                    "Jupiter is the third brightest natural object in the Earth's night sky, after the Moon and Venus.",
                    "The planet is primarily composed of hydrogen and helium, it lacks a well-defined solid surface.",
                    "Jupiter has at least 80 known moons and possibly many more, the four biggest are: Io, Europa, Ganymede and Callisto.",
                    "People have been observing Jupiter since prehistoric times."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="What position does Jupitor have in the order of the planets when counting from the sun?",
                        Answers={ "Fifth", "First", "Sixth", "Seventh" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="What was Jupiter the god of?",
                        Answers={ "The god of the underworld, Hades", "The roman king of the gods, Jupiter", "the goddess of magic, Hecate"},
                        CorrectAnswerIndex =1
                    },
                    new QuestionAndAnswer{
                        Question="How long does it take Jupiter to orbitate one round of the Sun?",
                        Answers={ "Around 22 Years", "Around 600 days", "Around 12 year", "Around 15 years" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="How many moons does Jupiter have?",
                        Answers={ "Ca. 20 moons", "Ca. 45 moons", "Ca. 70 moons", "Ca. 80 moons" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="Since when did humans start to observe the planet?",
                        Answers={ "Since yesterday", "Since last year", "Since prehistoric times", "Since last week" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What is the planet composed of?",
                        Answers={ "Solid surface", "Hydrogen and Helium", "water"},
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="What are the four biggest Moon called?",
                        Answers={ "Io, Callisto, Europa, and Ganymede", "Jupiter, Fo, Callisteo, and Phobos", "Miraculus, Saturn, Ganymede, and Quasimodo"},
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that Jupiter is the biggest planet in the Solar System?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex=0
                    }
                }
            },
         
         /// <summary>
         /// Saturn.
         /// </summary>
            new Planet
            {
                Name = "Saturn",
                Distance_from_sun = 1433449370,
                Diameter = 120500,
                Age = 4600000000,
                Rotation_period = 642,
                Rotation_speed = 35500,
                Orbital_period = 10756,
                Moons = 82,
                Mass = 5683 * Math.Pow(10, 26),
                Highest_temp = 57,
                Lowest_temp = -173,
                Statements ={
                    "Saturn is the sixth planet from the Sun and the second-largest in the Solar System.",
                    "It takes Saturn 10 759 days to finish one revolution around the Sun.",
                    "The outer atmosphere is generally bland and lacking in contrast, although long-lived features can appear.",
                    "Wind speeds on the planet can reach 1800 km/h.",
                    "Saturn's most notable feature is it's prominent ring system, which is composed mainly of ice particles, with a smaller amount of rocky debris and dust.",
                    "Saturn has at least 83 moons of which 53 are officially named, the largest one called &#34;Titan&#34;.",
                    "It's named after the roman god of wealth and agriculture and the father of Jupiter, Saturn."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="What position does Saturn have in the order of the planets when counting from the sun?",
                        Answers={ "First", "Fifth", "Tenth", "Sixth" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that it takes 10759 days for Saturn to orbitate one round of the Sun?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex =0
                    },
                    new QuestionAndAnswer{
                        Question="How many moons does Saturn have?",
                        Answers={ "53", "36", "83", "92" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What are the highest measured wind speeds on the planet?",
                        Answers={ "100km/h", "1800km/h", "320km/h", "960km/h"},
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that Saturn is the third largest planet in the Solar System?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Who is the planet named after?",
                        Answers={ "The greek god of titans, Cronus", "The roman god of wealth and agriculture, Saturn", "The greek goddess of snow, Khione", "The norse god of lightnings, Thor" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="What does Saturn have that no other planet has?",
                        Answers={ "A system of rings in orbit", "A special brand of candy", "A high-speed train"},
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="What is the largest moon of Saturn, called?",
                        Answers={ "Ghost", "Titan", "Zeus", "Giant" },
                        CorrectAnswerIndex=1
                    }
                }
            },
         
         /// <summary>
         /// Uranus.
         /// </summary>
            new Planet
            {
                Name = "Uranus",
                Distance_from_sun = 2870972200,
                Diameter = 51100,
                Age = 4600000000,
                Rotation_period = 1020,
                Rotation_speed = 9320,
                Orbital_period = 30687,
                Moons = 27,
                Mass = 8682 * Math.Pow(10, 25),
                Highest_temp = 4982,
                Lowest_temp = -224,
                Statements ={
                    "Uranus is the seventh planet of the Solarsystem.",
                    "It's named after the Greek god of the Sky, Uranus.",
                    "the planet orbits the Sun every 84 years.",
                    "Like Jupiter, it lacks a well-defined solid surface.",
                    "The planet's atmosphere is similar to Jupiter's and Saturn's in its primary composition of hydrogen and helium, but it contains more &#34;ices&#34;, such as water, or ex: ammonia.",
                    " Uranus has the coldest planetary atmosphere in the Solar System, with the minimum temperature of -224 °C",
                    "Wind speeds can reach 900 km/h.",
                    "The planet has 27 known moons.",
                    "Only one spacecraft visited the planet, in 1986, the &#34;Voyeur 2&#34;."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="What position does Uranus have in the order of the planets when counting from the sun?",
                        Answers={ "Third", "Seventh", "Fourth", "Eleventh" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="How long does it take Uranus to orbitate one round of the Sun?",
                        Answers={ "84 years", "105 years", "140 years", "56 years" },
                        CorrectAnswerIndex =0
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that Uranus doesn't have any solid material on the surface?",
                        Answers={ "Yes", "No" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Which planets can Uranus be compared to?",
                        Answers={ "Neptune and Mercury", "Mars and Venus", "Earth and Moon", "Jupiter and Saturn" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that Uranus has the coldest planetary atmosphere in the Solar System?",
                        Answers={ "Yes", "No" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Who is the planet named after?",
                        Answers={ "The greek god of the sky, Uranus", "The irish goddess of fate, Morrigan", "It wasn’t named after anybody" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="How many spacecraft has visited the planet?",
                        Answers={ "2", "5", "1", "10" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What are the highest measured wind speeds on the planet Uranus?",
                        Answers={ "450 km/h", "900 km/h", "500 km/h", "700 km/h" },
                        CorrectAnswerIndex=1
                    }
                }
            },

         /// <summary>
         /// Neptune.
         /// </summary>
            new Planet
            {
                Name = "Neptune",
                Distance_from_sun = 4503443661,
                Diameter = 49500,
                Age = 4600000000,
                Rotation_period = 960,
                Rotation_speed = 9650,
                Orbital_period = 60190,
                Moons = 14,
                Mass = 1024 * Math.Pow(10, 26),
                Highest_temp = 7000,
                Lowest_temp = -218,
                Statements ={
                    "Neptune is the eighth and the planet furthest from the Sun.",
                    "It has no well-defined solid surface, as being composed primarily of gasses and liquids.",
                    "The planet orbits the Sun every 165 years.",
                    "It's named after the roman god of the seas, Neptune.",
                    "Neptune has 14 known moons, the largest called Triton.",
                    "The planet's atmosphere is composed primarily of hydrogen and helium, along with traces of hydrocarbons and possibly nitrogen, though it contains more &#34;ices&#34;, than Jupiter or Saturn.",
                    "Like Uranus, only one spacecraft visited the planet, in 1989, &#34;The Voyeur 2&#34;.",
                    "Neptune's outer atmosphere is one of the coldest places in the Solar System, with the temperature around -218 °C, but at the planet's center is much hotter, notedly 5100 °C."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="Is it true that Neptune is the planet furthest from the Sun?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="How long does it take Neptune to orbitate one round of the Sun?",
                        Answers={ "200 years", "172 years", "165 years", "147 years" },
                        CorrectAnswerIndex =2
                    },
                    new QuestionAndAnswer{
                        Question="Who is the planet named after?",
                        Answers={ "The greek god of the seas, Poseidon", "The roman god of the seas, Neptune", "The egyptian god of the seas, Nu)" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="How many moons does Neptune have?",
                        Answers={ "10", "16", "14", "17" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What is the biggest moon in orbit of Neptune called?",
                        Answers={ "Triton", "Oceanus", "Styx", "Nereus" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that the planet has been visited by a lot of spacecrafts?",
                        Answers={ "Yes", "No" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="What is the temperature of Neptune's outer atmosphere?",
                        Answers={ "-162 °C", "-346 °C", "-218 °C", "-252 °C" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What is the temperature in the center Neptune's inner core?",
                        Answers={ "3700 °C", "4600 °C", "6600 °C", "5100 °C" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="What was the name of the spacecraft that visited Neptune?",
                        Answers={ "Voyeur 2", "MESSENGER", "Apollo 7", "It wasn’t named" },
                        CorrectAnswerIndex=0
                    },
                }
            },

         /// <summary>
         /// Pluto.
         /// </summary>
            new Planet
            {
                Name = "Pluto",
                Distance_from_sun = 5906376272,
                Diameter = 2274,
                Age = 4600000000,
                Rotation_period = 9180,
                Rotation_speed = 47.18,
                Orbital_period = 90520,
                Moons = 5,
                Mass = 1309 * Math.Pow(10, 22),
                Highest_temp = -223,
                Lowest_temp = -233,
                Statements ={
                    "Pluto is a dwarf planet in the Kuiper belt.",
                    "After the planet was discovered in 1930, it was declared to be the ninth planet from the Sun. Later this was questioned because of the distance and size, and this led to 2006, when it was reclassified as a dwarf planet.",
                    "It has 5 known moons: Charon, Styx, Nix, Kerberos and Hydra.",
                    "Back in 2015, a spacecraft, named &#34;New Horizons&#34; performed a flyby on Pluto, and it was the only visit to the planet.",
                    "Pluto orbits the Sun every 248 years.",
                    "The surface of Pluto is composed of more than 98% nitrogen ice, with traces of methane and carbon monoxide."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="Who is the planet named after?",
                        Answers={ "The norse goddess of death, Hela", "The greek god of the underworld, Hades", "The greek god of death, Thanatos", "The roman god of the underworld, Pluto" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question=" Is Pluto a normal planet?",
                        Answers={ "Yes", "no, It doesn’t exist", "It is unknown", "It is a dwarf planet" },
                        CorrectAnswerIndex =3
                    },
                    new QuestionAndAnswer{
                        Question="When was Pluto discovered by humans?",
                        Answers={ "1890", "1910", "1930", "1950" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="How long does it take Pluto to orbitate one round of the Sun??",
                        Answers={ "248 days", "248 months", "248 years" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="How many moons does Pluto have?",
                        Answers={ "15", "22", "5", "10" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What year was Pluto visited by a spacecraft?",
                        Answers={ "2006", "2012", "2009", "2015" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="What was the name of the spacecraft that visited the planet?",
                        Answers={ "New Horizons", "Voyeur 5", "Titanic 22", "Crazy Horse" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="What is Pluto composed of?",
                        Answers={ "Dirt", "Sugar", "Nitrogen Ice", "Salt", "Grass" },
                        CorrectAnswerIndex=2
                    }
                }
            },
        };

#endregion
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"{JsonSerializer.Serialize(planets_en)}");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"{JsonSerializer.Serialize(planets_da)}");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"{JsonSerializer.Serialize(planets_hu)}");
Console.ReadKey();


