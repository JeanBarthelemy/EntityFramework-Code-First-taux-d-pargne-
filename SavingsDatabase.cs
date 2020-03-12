using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;


namespace EntityFramework_Quete1
{
    public class SavingsDatabase : DbContext
    {
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<SavingAccount> SavingAccounts { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SavingsDatabase;Integrated Security=True");
        }
    }

    
}
