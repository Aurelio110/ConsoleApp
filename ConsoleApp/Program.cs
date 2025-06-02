using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
namespace ConsoleApp
{
    class ListSorter
    {
        public static void sort()
        {
            Console.WriteLine("Please enter 5 numbers you want to sort. \n");
            List<int> numbers = new List<int>();
            
            for(int i = 0; i < 5; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                numbers.Add(input);
               
            }
            numbers.Sort();
            Console.WriteLine("\n");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        class Reverser
        {
            public static void reverse()
            {
                Console.Write("Please enter a string to reverse: ");
                string input = Console.ReadLine();
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                string reversedString = new string(charArray);
                Console.WriteLine($"Reversed string: {reversedString}");
            }
        }
        class Facebook
        {
            private static IEnumerable<string> friendsInputList;

            public static void facebook()
            {
                Console.WriteLine("Welcome to the Facebook app!");
                Console.WriteLine("Please enter your name: ");
                string name = Console.ReadLine();
                Console.WriteLine($"Hello {name}! Welcome to Facebook.");
                Console.WriteLine("You can now start posting and connecting with friends!\nDo you want to check how many friends\nhave liked your last post?");
                string decision = Console.ReadLine();

                if (decision.ToLower() == "yes" || decision.ToLower() == "y")
                {
                    friends();
                }
                else if (decision.ToLower() == "no" || decision.ToLower() == "n")
                {
                    Console.WriteLine("Okay, have a great day!");
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                    facebook();
                }
            }

            public static void friends()
            {
                List<string> friendsInputList = new List<string>();
                string friendsInput = "1";

                Console.WriteLine("Enter the names of your friends:");
                friendsInput = Console.ReadLine();
                friendsInputList = friendsInput.Split(',').Select(f => f.Trim()).ToList();

                if (friendsInputList.Count <= 2)
                {
                    foreach (string friend in friendsInputList)
                    {
                        Console.WriteLine($"{friend}, ");
                    }
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine($"{friendsInputList[0]}, {friendsInputList[1]} and {friendsInputList.Count - 2} more friends liked your post!\n\n");
                }

            }
        }
        class FindTheMaximum
        {
            public static void findTheMax()
            {
                Console.Write("Please enter the numbers seperated with a comma which you want to compare: ");
                string numbers = Console.ReadLine();
                string[] splittedNumbers = numbers.Split(',');
                int[] intsFromString = new int[splittedNumbers.Length];

                for (int i = 0; i < splittedNumbers.Length; i++)
                {
                    intsFromString[i] = (int)BigInteger.Parse(splittedNumbers[i]);
                }
                Array.Sort(intsFromString);

                Console.WriteLine($"\n{intsFromString.AsQueryable().Last()} is the maximum!");
            }
        }
        class guessTheRandom
        {
            public static void randomNum()
            {
                Random random = new Random();
                int rand = random.Next(1, 10);
                Console.WriteLine(rand);
                Console.WriteLine("\nGuess the number between 1 and 10: \n");

                for (int i = 1; i <= 4; i++)
                {
                    Console.Write($"{i}. try: ");
                    int guessed = Convert.ToInt32(Console.ReadLine());

                    if (guessed == rand)
                    {
                        Console.WriteLine("\nVictory!\n");
                        break;
                    }
                    else if (i == 4)
                    {
                        Console.WriteLine("\nYou lost!\n");
                    }
                    else
                    {
                        continue;
                    }
                }

            }
        }
        class Factor
        {
            public static void factorial()
            {
                Console.Write("Please enter an Integer: ");
                int num = Convert.ToInt32(Console.ReadLine());

                while (num > 0)
                {
                    int n = num;
                    for (int i = n - 1; i > 0; i--)
                    {
                        n *= i;
                    }

                    Console.WriteLine($"{num}! = {n}");
                    num--;
                }
            }
        }
        class Calculate
        {
            public static void calculatingPrevNum()
            {
                double[] numbers = new double[100];
                Console.WriteLine("Please enter the numbers which you want to sumarize.\n");
                for (int i = 0; i < numbers.Length; i++)
                {

                    String num = (Console.ReadLine());
                    if (num == "ok")
                    {
                        break;
                    }
                    else
                    {
                        numbers[i] = Convert.ToDouble(num);
                        continue;
                    }

                }

                double sum = numbers.Sum(x => x);
                Console.WriteLine($"The sum of the given numbers is: {sum}.\n\n");


            }
        }
        class Divisible
        {
            public static void divByThree()
            {
                for (var i = 3; i <= 100; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

        class Time
        {
            public static void timer()
            {
                for (int i = 5; i >= 1; i--)
                {
                    Console.WriteLine("\n\nThe program restarts in: " + i);
                    Thread.Sleep(500);
                    Console.Write("\n-");
                    for (int j = 1; j < 36; j++)
                    {
                        Console.Write("-");
                    }
                    Thread.Sleep(500);
                }
                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine();
                }
            }
        }
        class Speed
        {
            public static void speedLim()
            {
                Console.Write("Please enter the speed limit: ");
                var limit = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter the current speed of the car: ");
                var currentSpeed = Convert.ToInt32(Console.ReadLine());

                if (limit >= currentSpeed)
                {
                    Console.WriteLine("The current speed isn't above the speed limit.");
                }
                else if (currentSpeed - limit > 1 && currentSpeed - limit <= 4)
                {
                    Console.WriteLine("You have luck! Your were going to fast but it isn't enough to give you any point.");
                }
                else if (currentSpeed - limit >= 5 && currentSpeed - limit <= 60)
                {
                    double demeritPoints = (currentSpeed - limit) / 5;
                    Console.WriteLine("Your were going to fast! Therefor you have " + (int)demeritPoints + "point/points");
                }
                else
                {
                    Console.WriteLine("Your drivers licence is suspended!");
                }

                Time.timer();
            }


            class landscapeOrPortrait
            {
                public static void landXport()
                {
                    Console.Write("Please enter the width:");
                    var width = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter the height:");
                    var height = Convert.ToInt32(Console.ReadLine());

                    if (width > height) Console.WriteLine("It's landscape.");
                    else if (height == width) Console.WriteLine("It's square.");
                    else Console.WriteLine("It's portrait.");

                    Time.timer();
                }
            }

            class minMax
            {
                public static void minOmax()
                {
                    Console.Write("Please enter the first of two numbers:");
                    var firstNum = Convert.ToInt32(Console.ReadLine());
                    Console.Write("And now enter the second number: ");
                    var secondNum = Convert.ToInt32(Console.ReadLine());

                    switch (firstNum < secondNum)
                    {
                        case true:
                            Console.WriteLine("The first number is bigger than the second one.");
                            break;
                        case false:
                            if (firstNum == secondNum) Console.WriteLine("Both numbers have the same value! (" + firstNum + ")");
                            else
                                Console.WriteLine("The second number is bigger than the first one.");
                            break;
                    }
                    Time.timer();
                }

                class isNumValid
                {
                    public static void validation()
                    {
                        Console.Write("Please enter a number between 1 and 10: ");
                        string numberString = Console.ReadLine();

                        if (numberString == "1" || numberString == "2" || numberString == "3" || numberString == "4" || numberString == "5" || numberString == "6" || numberString == "7" || numberString == "8" || numberString == "9" || numberString == "10")
                        {
                            Console.WriteLine("The entered number is valid!");
                        }
                        else
                        {
                            Console.WriteLine("The number is invalid.");
                        }

                        Time.timer();
                    }

                }
                class main
                {
                    static void Main(string[] args)
                    {
                        string operation;
                        do
                        {
                            Console.OutputEncoding = System.Text.Encoding.UTF8;

                            Console.WriteLine("\n\nPlease choose one of the given operations!");
                            Console.WriteLine();
                            Console.WriteLine("For number validation press '1' and enter");
                            Console.WriteLine("For min/max operation press '2' and enter");
                            Console.WriteLine("To use the format operation press '3' and enter");
                            Console.WriteLine("For speed limit control press '4' and enter");
                            Console.WriteLine("Divisible by 3 press '5' and enter");
                            Console.WriteLine("Calculation of the givern numbers press '6' and enter");
                            Console.WriteLine("Faculty of entered number press '7' and enter");
                            Console.WriteLine("Guess the random number '8' and enter");
                            Console.WriteLine("Find the maximum '9' and enter");
                            Console.WriteLine("For 'How many numbers between 1 and 100 are divisible by 3' press '5' and enter");
                            Console.WriteLine("Press 'x' to end the program.");
                            Console.WriteLine();
                            Console.Write("-------------> ");

                            operation = Console.ReadLine();

                            switch (operation)
                            {

                                case "1":
                                    isNumValid.validation();
                                    break;

                                case "2":
                                    minMax.minOmax();
                                    break;

                                case "3":
                                    landscapeOrPortrait.landXport();
                                    break;

                                case "4":
                                    Speed.speedLim();
                                    break;

                                case "5":
                                    Divisible.divByThree();
                                    break;

                                case "6":
                                    Calculate.calculatingPrevNum();
                                    break;

                                case "7":
                                    Factor.factorial();
                                    break;

                                case "8":
                                    guessTheRandom.randomNum();
                                    break;

                                case "9":
                                    FindTheMaximum.findTheMax();
                                    break;

                                case "facebook":
                                    Facebook.facebook();
                                    break;

                                case "reverse":
                                    Reverser.reverse();
                                    break;

                                case "sort":
                                    ListSorter.sort();
                                    break;
                            }
                        } while (operation != "x");
                    }
                }
            }
        }
    }
}