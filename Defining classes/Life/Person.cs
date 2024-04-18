using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    public class Person
    {
        //prop
        //public string Name { get; set; }

        //propfull
        private string name;
        private int age;
        private List<BankAccount> accounts = new List<BankAccount>();

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public List<BankAccount> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        public double GetBalance()
        {
            return this.accounts.Sum(x => x.Balance);
        }
    }
}
