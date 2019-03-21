using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Xml.Schema;
using Console = System.Console;

namespace BudgetConsole
{
    class Program
    {
        public const float V = .28f;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();
           // Not needed yet
           // Expensesreport exreport = new Expensesreport();

            Console.WriteLine("Hello " +name+", this app is designed to help you make smart financial choices.");
            Thread.Sleep(1000);
            Console.WriteLine("Please Choose an option of what you would like to check");
            Console.WriteLine("1. Basic Budget Check");
            Console.WriteLine("2. Auto Loan Calculator");
            Console.WriteLine("3. Auto Ownership Costs");
            Console.WriteLine("4. How soon til you can achieve FIRE");

            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            if (choice == 1)
                {
                Console.WriteLine("Welcome to the Basic Budget Check "+name+", let's help you determine if the basics of your monthly budget are strong.");
                Thread.Sleep(1000);
                Console.WriteLine("What is your currently monthly after tax income?");
                float monthlyincome = int.Parse(Console.ReadLine());
                // not needed yet
                // exreport.AddExpense(monthlyincome);

                Console.WriteLine("What are is your Mortgage & Tax payment?  Or if you rent, what is your monthly rent?");
                float monthlyrent = int.Parse(Console.ReadLine());

                Console.WriteLine("How much are you spending on Groceries?");
                int groceries = int.Parse(Console.ReadLine());

                Console.WriteLine("How much are your car related expenses?");
                int auto = int.Parse(Console.ReadLine());

                //Calculations to find the ratios and lead to output later
                float totalexpenses = monthlyrent + groceries + auto;


                if (monthlyrent / monthlyincome <= V)
                {
                    Console.WriteLine("You are doing a good job of keeping your housing payments in line with your budget.");
                }
                else
                {
                    float rentratiopercent = monthlyrent / monthlyincome * 100;
                    float rightrent = V * monthlyincome;
                    Console.WriteLine("It looks like you might be spending too much money on your housing.  Try to keep costs below 28%.  You are at " + rentratiopercent + "%");
                    Console.WriteLine("You want to be spending no more than $" + rightrent + " a month.");
                }


                if (totalexpenses < monthlyincome)
                {
                    Console.WriteLine("It looks like you're looking good for your major purchases.  You are only spending $" + totalexpenses + " a month on auto, rent, and groceries.  While bringing in $" + monthlyincome);
                }
                else
                {
                    Console.WriteLine("You are spending more than you make on major purchases.  You need to either cut spending somewhere or increase your income.");
                }

                }

            else if (choice ==2)
            {
                Console.WriteLine("Are you in the market for a new Auto?  Let's find out how much you can afford so that you don't get burdened by payments");
                Thread.Sleep(1000);
            }
            //if Debug
            if (Debugger.IsAttached== true)
            { 
                Console.WriteLine("Press any key to Close...");
                Console.ReadLine();
            }
            else
            {
                //assume we are running from IDE without debugger
            }

        }
    }
}
