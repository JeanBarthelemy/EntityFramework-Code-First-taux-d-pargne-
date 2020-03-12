using System;
using System.Windows;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace EntityFramework_Quete1
{
    public class Program
    {
        static void Main(string[] args)
        {
            using(var context = new SavingsDatabase())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var person = new Person()
                {
                    Name = "M. Richard"
                };

                person.SavingAccounts = new List<SavingAccount>
                {
                    new SavingAccount { Amount = 2000000, SavingsRate = 0.6},
                    new SavingAccount { Amount = 250000, SavingsRate = 0.15},
                    new SavingAccount { Amount = 10000000, SavingsRate = 0.2}
                };

                context.Add(person);
                context.SaveChanges();

                DateTime date1 = new DateTime(2020, 3, 9);
                DateTime date2 = new DateTime(2023, 3, 9);
                double totalAmountSaved = SavingCalculator.CalculateTotalSaved(date1, date2, person);
                //MessageBox.Show("The total amount saved in this period : " + totalAmountSaved, "Amout Saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
       
        }
    }
}
