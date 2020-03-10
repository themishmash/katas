//Below are some basic coding problems.If you have never coded before in a specific language these are good problems to start off with.

//In your solutions try and keep things as simple as possible (i.e.keep it console based)

//Write a program that prints ‘Hello World’ to the screen.
//Write a program that asks the user for their name and greets them with their name.
//Write a program that asks the user for their name and only greets you if you are Alice or Bob.
//Write a program that asks the user for a number n and prints the sum of the numbers 1 to n
//Write a program that asks the user for a number n and prints the sum of the numbers 1 to n if the number is a multiple of three or five, e.g. 3, 5, 6, 9, 10, 12, 15 for n= 17
//Write a program that asks the user for a number n and gives them the possibility to choose between computing the sum and computing the product of 1,…, n.
//Write a program that prints a multiplication table for numbers up to 12.
//Write a guessing game where the user has to guess a secret number.After every guess the program tells the user whether their number was too large or too small.At the end the number of tries needed should be printed.It counts only as one try if they input the same number multiple times consecutively.
//Write a program that prints the next 20 leap years.

using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicCoding
{
    public class BasicCoding
    {
        public static void Solution()
        {
            Console.WriteLine("Hello world");
            
        }

        public static void Name()
        {
            Console.WriteLine("hello, what's your name?");
            string userName = Console.ReadLine().ToLower();

            if (userName == "alice" || userName == "bob")
            {
                Console.WriteLine($"Hello {char.ToUpper(userName[0]) + userName.Substring(1)}");
            }
        }

        //Not sure what this is
        public static void NumberCount()
        {
            Console.WriteLine("What number do you want to count up to?");
            string userNumber = Console.ReadLine();
            int number;
            if (!Int32.TryParse(userNumber, out number))
            {
                Console.WriteLine("Please enter a number");
            }

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(i+1);
            }
        }


        //Write a program that asks the user for a number n and prints the sum of the numbers 1 to n
        public static void NumberAdd()
        {
            Console.WriteLine("What number do you want to add up to?");
            string userNumber = Console.ReadLine();
            int number;
            if (!Int32.TryParse(userNumber, out number))
            {
                Console.WriteLine("Please enter a number");
            }

            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                sum = sum + i;
            }
            Console.Write(sum);

        }



        //Write a program that asks the user for a number n and prints the sum of the numbers 1 to n if the number is a multiple of three or five, e.g. 3, 5, 6, 9, 10, 12, 15 for n= 17
        public static void Mult3or5()
        {
            int sum; //by default it will be 0
            Console.WriteLine("Please input a number");
            string userNumber = Console.ReadLine();
            int number;
            if (!Int32.TryParse(userNumber, out number))
            {
                Console.WriteLine("Please enter a number");
            }

            for (int i = 0; i < number; i++)
                if ((i % 3 == 0 || i % 5 == 0))
                {
                    {

                        sum = sum + i;

                    }
                } 

            Console.Write(sum);
        }


        //Write a program that asks the user for a number n and gives them the possibility to choose between computing the sum and computing the product of 1,…,n.

        public static void AddOrMult()
        {
            Console.WriteLine("What would you like to do? Please enter a number");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Multiply");
            string input = Console.ReadLine();
            int number;
            if (!Int32.TryParse(input, out number))
            {
                Console.WriteLine("Please enter a number");
            }

            
            switch (number)
            {
                case 1:
                    Console.WriteLine("Please enter a number you want to add up to");
                    string userNumber = Console.ReadLine();
                    int numberAdd;

                    if (!Int32.TryParse(userNumber, out numberAdd))
                    {
                        Console.WriteLine("Please enter a number");
                    }
                    int sum = 0;
                    for (int i = 0; i < numberAdd; i++)
                        sum = sum + i;

                    Console.WriteLine(sum);
                    break;

                case 2:
                    Console.WriteLine("Please enter a number you want to multiply up to");
                    string userNumberMult = Console.ReadLine();
                    int numberMult;

                    if (!Int32.TryParse(userNumberMult, out numberMult))
                    {
                        Console.WriteLine("Please enter a number");
                    }
                    int sumMult = 1;
                    for (int i = 1; i < numberMult; i++)
                        sumMult = sumMult * i;

                    Console.Write(sumMult);
                    break;

            }

            
        }

        //Write a program that prints a multiplication table for numbers up to 12.
        public static void MultTable()
        {
            Console.WriteLine("What number would you like to see the mutiplication table for? Please pick a number between 1 and 12");

            string userNumber = Console.ReadLine();
            int number;
            if (!Int32.TryParse(userNumber, out number))
            {
                Console.WriteLine("Please enter a number");
            }

            int sum = 1;
            for (int i = 1; i < 13; i++)
            {
                sum = i * number;
                Console.WriteLine($"{i} x {number} is: {sum} ");
            }
        }


        //Write a guessing game where the user has to guess a secret number. After every guess the program tells the user whether their number was too large or too small. At the end the number of tries needed should be printed. It counts only as one try if they input the same number multiple times consecutively.

        public static void GuessGame()
        {
            //making secret random number
            Random random = new Random();
            int secretNumber = random.Next(0, 100);
            Console.WriteLine(secretNumber);

            Console.WriteLine("Please guess a number between 0 and 100!");


            //list to store all the guesses
            List<int> guessList = new List<int>();
            

            int attempts = 0;
            while (true)
               
                {
                
                    {
                    
                    string userNumber = Console.ReadLine();
                    
                    int number;
                        if (!Int32.TryParse(userNumber, out number))
                        {
                            Console.WriteLine("Please enter a number");
                        }

                    if (number < secretNumber)
                        {

                        if (guessList.Contains(number) && number == guessList.LastOrDefault())
                        {
                            Console.WriteLine("Too low. You have guessed that just before. Please enter new number");
                        }
                                else if (guessList.Contains(number))
                        {
                            Console.WriteLine("Too low. You guessed that already! Please enter new number");
                            attempts++;
                        }
                        else
                        {
                            Console.WriteLine("That is too low, please enter again");
                            
                            attempts++;
                        }

                        guessList.Add(number);
                    }

                    else if (number > secretNumber)
                        {
                        if (guessList.Contains(number) && number == guessList.LastOrDefault())
                        {
                            Console.WriteLine("Too high. YOu guessed that just before. Please enter new number");
                        }
                        else if (guessList.Contains(number))
                        {
                            Console.WriteLine("Too high. You guessed that already! Please enter new number");
                            attempts++;
                        }
                        else
                        {
                            Console.WriteLine("That is too high, please enter again");
                            
                            attempts++;
                        }

                        guessList.Add(number);
                    }


                        else
                        {
                            Console.WriteLine($"Well done! You had {attempts + 1} tries!");

                        foreach (int i in guessList)
                        {
                            Console.WriteLine($"you guessed: {i}");
                        }
                        
                            break;
                        }
                    }
                }

        }

        public static void LeapYear()
        {
            Console.WriteLine("What is the current year?");
            string userNumber = Console.ReadLine();
            int number;
            if (!Int32.TryParse(userNumber, out number))
            {
                Console.WriteLine("Please enter a number");
            }

            for (int i = 1; i <= 20; i++)
            {
                int year = number + i;
                if (year % 4 == 0)
                {
                    Console.WriteLine($"The next 20 leap years are: {year} ");
                }
 
            }

        }
    }
}
