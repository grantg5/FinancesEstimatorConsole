using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialEstimatorConsole
{
    class FinancialEstimatorConsole
    {
        static double Estimator(int cash, int purchasesTotal, int cashIn, int months, int leftOver)
        {
            /// <summary>Calculates how much can be spent per month given the paramaters.</summary>
            /// <param name="cash">The total cash available at the begining.</param>
            /// <param name="purchasesTotal">Future large purchases expected.</param>
            /// <param name="cashIn">Any expected income before the months are over.</param>
            /// <param name="months">Amount of months to make this money last.</param>
            /// <param name="leftOver">The amount desired to be leftover/to be a cushon after the months.</param>
            double cashPerMonth = 0;
            
            int realCash = cash;
            realCash -= purchasesTotal;
            realCash += cashIn;
            realCash -= leftOver;

            double rawCashPerMonth = realCash / months;
            cashPerMonth = Math.Round(rawCashPerMonth, 2);

            return cashPerMonth;
        }

        static void Main(string[] args)
        {
            /// <summary>Main method of the application, takes in stuff from command line, calls Estimator.</summary>
            int cash = 0;
            int purchasesTotal = 0;
            int cashIn = 0;
            int months = 0;
            int leftOver = 0;
            double cashPerMonth = 0;
            
            // TODO Account for dollar signs, commas in user input.
            Console.WriteLine("Welcome to the Financial Estimator.\n");
            
            Console.Write("Please enter your starting cash: ");
            cash = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPlease enter what you expect to spend on large future purchases: ");
            purchasesTotal = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPlease enter any income expected in the future: ");
            cashIn = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPlease enter how many months this money needs to last: ");
            months = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPlease enter how much cash should be left over or be a cushon: ");
            leftOver = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            cashPerMonth = FinancialEstimatorConsole.Estimator(cash, purchasesTotal, cashIn, months, leftOver);
            Console.WriteLine("Total cash per month: $" + Convert.ToString(cashPerMonth));
            Console.ReadKey();
        }
    }
}
