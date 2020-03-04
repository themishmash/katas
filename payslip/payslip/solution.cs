//Basic Payslip Kata
//At MYOB we rock at payroll, the most important part of payroll is getting your payslip!

//Overview
//We have the following payslip rules:

//Pay period = per calendar month
//Gross income = annual salary / 12 months
//Income tax = based on the tax table provided below
//Net income = gross income - income tax
//Super = gross income x super rate
//All calculation results should be rounded to the whole dollar.If >= 50 cents round up to the next dollar increment, otherwise round down.
//When supplied employee details: first name, last name, annual salary (positive integer) and super rate (0% - 50% inclusive), payment start date, generate pay slip information with name, pay period, gross income, income tax, net income and super.

//The following rates for 2017-18 apply from 1 July 2017:


//Taxable Income  Tax on this Income
//$0 - $18,200	Nil
//$18,201 - $37,000	19c for each $1 over $18,200
//$37,001 - $87,000	$3,572 plus 32.5c for each $1 over $37,000
//$87,001 - $180,000	$19,822 plus 37c for each $1 over $87,000
//$180,001 and over	$54,232 plus 45c for each $1 over $180,000
//For example, the payment in March for an employee with an annual salary of $60,050 and a super rate of 9% is:


//pay period = Month of March (01 March to 31 March)
//gross income = 60,050 / 12 = 5,004.16666667 (round down) = 5,004
//income tax = (3, 572 + (60, 050 - 37, 000) x 0.325) / 12 = 921.9375 (round up) = 922
//net income = 5,004 - 922 = 4,082
//super = 5,004 x 9% = 450.36 (round down) = 450
//Your Task
//Generate a basic payslip application.You should be able to enter a single employee details, the application will generate a basic payslip.

//Everything will be done via the console.


//An example run through of of how this console would be...


//Welcome to the payslip generator!


//Please input your name: John
//Please input your surname: Doe
//Please enter your annual salary: 60050
//Please enter your super rate: 9
//Please enter your payment start date: 1 March
//Please enter your payment end date: 31 March

//Your payslip has been generated:


//Name: John Doe
//Pay Period: 01 March – 31 March
//Gross Income: 5004  
//Income Tax: 922 
//Net Income:4082 
//Super: 450  


//Thank you for using MYOB!


//1. ask for name
//2. ask for surname
//3. Ask for annual salary
    //if statements for salary only
    //calculate gross income per month. salary / 12 (month)
    //calculate income tax per month. Tax rate / 12
    //calculate net income. Gross income - income tax
//4. ask for super rate
    //calculate super. Gross income * 9%
//5. Ask for pay period - can it be listed as options instead of person entering? Check that out

//6. Spit out the payslip
    //Console.WriteLine...blah blah blah with string interpolation

//MAKE SURE IT IS ALL ROUNDING DOWN

using System;
using System.Collections.Generic;

namespace payslip
{
    public class payslip
    {
        public static void solution()
        {
            while (true)
            {
                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();
                //Console.WriteLine($"{name}");
                Console.WriteLine("What is your surname?");
                string surname = Console.ReadLine();
                Console.WriteLine("What is your annual salary?");
                string salary = Console.ReadLine();
                decimal salaryNum;

                if (!decimal.TryParse(salary, out salaryNum))
                {
                    Console.WriteLine("Please enter number");

                }

                int grossIncome = ((int)Math.Round(salaryNum) / 12);
                //Console.WriteLine(grossIncome);


                //calculate income tax per month
                decimal incomeTax;
                decimal a = 0.19M;
                decimal b = 0.325M;
                decimal c = 0.37M;
                decimal d = 0.45M;


                //TO PRINT OUT - VARIABLES TO ACCESS
                //print out
                //name
                //lastname
                int tax; //round up
                int netIncome;
                decimal super; //contribution not amount
                int superSuper; //amount of super
                string startDate;
                string endDate;



                if (salaryNum <= 18200)
                {
                    incomeTax = 0;
                    tax = (int)Math.Round(incomeTax);
                    netIncome = grossIncome - tax;
                }
                else if (salaryNum > 18200 && salaryNum <= 37000)
                {
                    incomeTax = ((salaryNum - 18200) * a) / 12;
                    tax = (int)Math.Round(incomeTax);
                    //Console.WriteLine(tax);
                    netIncome = grossIncome - tax;
                }

                else if (salaryNum > 37000 && salaryNum <= 87000)
                {
                    incomeTax = (3572 + (salaryNum - 37000) * b) / 12;
                    tax = (int)Math.Round(incomeTax); //this gives 922 - rounding up
                    netIncome = grossIncome - tax;
                }
                else if (salaryNum > 87000 && salaryNum <= 180000)
                {
                    incomeTax = (19822 + (salaryNum - 87000) * c) / 12;
                    //Console.WriteLine(incomeTax);
                    tax = (int)Math.Round(incomeTax);
                    netIncome = grossIncome - tax;
                }
                else
                {
                    incomeTax = (54232 + (salaryNum - 180000) * d) / 12;
                    tax = (int)Math.Round(incomeTax);
                    netIncome = grossIncome - tax;

                }

                Console.WriteLine("What is your super contribution rate?");
                string superRate = Console.ReadLine();

                if (!decimal.TryParse(superRate, out super))
                {
                    Console.WriteLine("Please enter number");

                }

                //In decimal
                decimal superTotal = grossIncome * (super / 100);

                //To get rounding
                superSuper = (int)Math.Round(superTotal);

                Console.WriteLine("Please enter your payment starting date");
                startDate = Console.ReadLine();

                Console.WriteLine("Please enter your payment ending date");
                endDate = Console.ReadLine();


                Console.WriteLine($"Name: {name} {surname}");
                Console.WriteLine($"Pay Period: {startDate} - {endDate}");
                Console.WriteLine($"Gross Income: {grossIncome}");
                Console.WriteLine($"Income Tax: {tax}");
                Console.WriteLine($"Net Income: {netIncome}");
                Console.WriteLine($"Super: {superSuper}");


            }

        }

    }
}
