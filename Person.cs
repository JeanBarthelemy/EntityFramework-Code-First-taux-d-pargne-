using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework_Quete1
{
    public class Person
    {
        public Guid PersonId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<SavingAccount> SavingAccounts { get; set; }

    }
}
