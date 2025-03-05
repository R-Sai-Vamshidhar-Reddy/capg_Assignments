using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessmentc_
{
    public class Bank
    {
        public static double InterestRate { get; private set; }

        public static void SetInterestRate(double newRate)
        {
            InterestRate = newRate;
        }

        public double Balance { get; private set; }

        public Bank(double initialBalance)
        {
            Balance = initialBalance;
        }

        public double CalculateInterest()
        {
            return Balance * InterestRate;
        }
    }

    
}
