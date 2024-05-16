using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int labselect = 0;
            Console.WriteLine("Select Lab");
            Console.WriteLine("1. Sample Text Replace Please");
            Console.WriteLine("2. Sample Text Replace Please");
            Console.WriteLine("3. Day and Hour Calculator");
            Console.WriteLine("4. Robot Rob Counter");
            Console.WriteLine("5. Sample Text Replace Please");
            Console.WriteLine("6. Sample Text Replace Please");
            Console.WriteLine("7. Sample Text Replace Please");
            Console.WriteLine("8. Sample Text Replace Please");
            labselect = Convert.ToInt32(Console.ReadLine());
            switch (labselect)
            {
                case 0:
                    Lab_1();
                    break;
                case 1:
                    Lab_2();
                    break;
                case 3:
                    Lab_3();
                    break;
                case 4:
                    Lab_4();
                    break;
                case 5:
                    lab_5();
                    break;
                case 6:
                    lab_6();
                    break;
                case 7:
                    lab_7();
                    break;
                case 8:
                    lab_8();
                    break;
            }

            void Lab_1()
            {
                string temp;
                int number, turns = 6;
                char userinput = '\0';
                bool close = false;
                Random random = new Random();
                int computerchosen = random.Next(1, 101);

                Console.WriteLine($"random number={computerchosen}");


                Console.WriteLine("Welcome to The game Player!");
                Console.WriteLine("The computer has chosen a number between 1-100.");
                Console.WriteLine("...............................................");
                Console.WriteLine("Goodluck");
                do
                {
                    do
                    {
                        Console.WriteLine("Guess a number from 1-100.");
                        number = Convert.ToInt32(Console.ReadLine());
                        turns--;
                        if (number > computerchosen)
                        {
                            Console.WriteLine("Your number is high");
                        }

                        else if (number < computerchosen)
                        {
                            Console.WriteLine("Your number is low");
                        }

                        else
                        {
                            Console.WriteLine("You guessed it right");
                            close = true;
                        }
                        Console.WriteLine($"you have {turns} turns left..");
                    }
                    while (turns > 0 && close != true);

                    Console.WriteLine("Please Enter your answer: y or n");
                    temp = Console.ReadLine();
                    userinput = Convert.ToChar(temp);
                } while ((userinput != 'y') && (userinput != 'n'));
                Console.WriteLine("Thank you");
                Console.ReadLine();

            }
            void Lab_2()
            {
                Console.WriteLine("Lab2");
                List<int> scores = new List<int>() { 78, 89, 92, 65, 70, 85, 92, 78, 93, 80 };

                int highestScore = 0;
                foreach (var score in scores)
                {
                    if (score > highestScore)
                    {
                        highestScore = score;
                    }
                }
                Console.WriteLine("Highest Score: " + highestScore);

                List<int> noDuplicates = new List<int>();
                foreach (var score in scores)
                {
                    if (!noDuplicates.Contains(score))
                    {
                        noDuplicates.Add(score);
                    }
                }
                foreach (var score in noDuplicates)
                {
                    Console.WriteLine(score);
                }

            }
            void Lab_3()
            {
                Console.WriteLine("Lab3");
                string temp;
                int days, hours, totalhours;
                Console.WriteLine("How many hours would you like to be converted to days and hours");
                temp = Console.ReadLine();
                totalhours = Convert.ToInt32(temp);
                days = totalhours / 24;
                hours = totalhours % 24;
                Console.WriteLine($"That is {days} Days and {hours} Hours");
                Console.ReadLine();
            }
            void Lab_4()
            {
                Console.WriteLine("Thank you for selecting Robot Rob Robot Counter");
                Random randljo = new Random();
                int playernumber = 0;
                int cpucurrent = 0;
                int cpumax = 100;
                int cpumin = 1;
                int guessesneeded = 0;
                Console.WriteLine("Robot Rob Robot Counter");
                Console.WriteLine("Robot Rob: Hello Give Me A Number Between 1 and 100");
                playernumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Robot Rob: Thanks!");
                cpucurrent = randljo.Next(cpumin, cpumax);
                Console.WriteLine($"Robot Rob: I Think The Number Is {cpucurrent}");
                do
                {
                    guessesneeded += 1;
                    Console.WriteLine($"Robot Rob: Oh I Got It Wrong :[ ");
                    Console.WriteLine($"Robot Rob: Was It Higher Or Lower");
                    Thread.Sleep(randljo.Next(200, 500));
                    if (cpucurrent > playernumber)
                    {
                        Console.WriteLine($"Robot Rob: So The Number Is Smaller");
                        Thread.Sleep(randljo.Next(200, 500));
                        cpumax = cpucurrent;
                    }
                    if (cpucurrent < playernumber)
                    {
                        Console.WriteLine($"Robot Rob: So The Number Is Bigger");
                        Thread.Sleep(randljo.Next(200, 500));
                        cpumin = cpucurrent + 1;
                    }
                    cpucurrent = randljo.Next(cpumin, cpumax);
                    Thread.Sleep(randljo.Next(200, 500));
                    Console.WriteLine($"Robot Rob: I Think The Number Is {cpucurrent}");


                } while (cpucurrent != playernumber);
                Console.WriteLine($"Robot Rob: I Got It Right!");
                Console.WriteLine($"Robot Rob: The Number Was {cpucurrent}");
                Console.WriteLine($"Robot Rob: It Took Me {guessesneeded} Tries To Get It Right");
                Console.WriteLine("Press enter to exit");
                Console.ReadLine();

            }
            void lab_5()
            {
                string temp;
                char guess;
                int guessconverted;

                Console.WriteLine("Welcome Player, to the game of guessing the side of the coin");
                Console.WriteLine("Please decide one among the two Head/Tails please input he alphabet h for heads and t for tails.");
                temp = Console.ReadLine();
                guess = Convert.ToChar(temp);
                Random rand = new Random();
                int computerguess = rand.Next(2);
                if (guess == 'h')
                {
                    guessconverted = 0;
                }
                else
                {
                    guessconverted = 1;
                }



                Console.WriteLine("Flipping the coin.....");
                Thread.Sleep(000);
                if (computerguess == 0)
                {
                    Console.WriteLine("flip result is heads.");
                }
                else
                {
                    Console.WriteLine("flip result is tails.");
                }


                if (guessconverted == computerguess)
                {
                    Console.WriteLine("WIN!");
                    Console.Beep(10050, 1000);
                    Console.Beep(10000, 1000);
                    Console.Beep(10000, 1000);
                }
                else
                {
                    Console.WriteLine("Lose!");
                }
                Console.ReadLine();
            }
            void lab_6()
            {

                string name, temp;
                int height, width, area;
                Console.WriteLine("WHAT'S YOUR NAME?");
                name = Console.ReadLine();
                Console.WriteLine("What's the height of the rectangle?");
                temp = Console.ReadLine();
                height = Convert.ToInt32(temp);
                Console.WriteLine("What's the width of the rectangle?");
                temp = Console.ReadLine();
                width = Convert.ToInt32(temp);
                area = height * width;
                Console.WriteLine($"Hello {name}, The total Area of the Rectangle is {area}.");
            }
            void lab_7()
            {

            }
            void lab_8()
            {

            }
        }

    }
}
