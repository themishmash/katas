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

        //how to get this to work and return nothing if not multiple of 3 or 5?
        public static void Mult3or5()
        {
            int ? sum = null;
            Console.WriteLine("Please input a number");
            string userNumber = Console.ReadLine();
            int number;
            if (!Int32.TryParse(userNumber, out number))
            {
                Console.WriteLine("Please enter a number");
            }

            for (int i = 0; i <= number; i++)
                if (number % 3 == 0 || number % 5 == 0)
                {
                    {
                        sum = sum + i;

                    }
                } //var numInput = number == 0 ? string.Empty : number.ToString();

            Console.Write(sum);
        }


       


    }
}
