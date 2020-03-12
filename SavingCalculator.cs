using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework_Quete1
{
    public class SavingCalculator
    {
        public static double CalculateTotalSaved(DateTime begin, DateTime end, Person person)
        {
            double totalSaved = 0;
            TimeSpan interval = end - begin;
            int yearsNb = Convert.ToInt32((interval.Days)/365);
            double AmountAtAccountOpening = 0;
            foreach (SavingAccount s in person.SavingAccounts)
            {
                totalSaved = totalSaved + s.Amount + (s.Amount * s.SavingsRate * yearsNb);
                AmountAtAccountOpening = AmountAtAccountOpening + s.Amount;
            }

            Console.WriteLine("The total amount of the three savings account is {0} $ which means " +
                "that the interests earned in that interval of time are {1} $.", totalSaved, totalSaved - AmountAtAccountOpening);
            return totalSaved;
        }

    }
}
