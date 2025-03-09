using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcc
{
    class Program
    {
        static void Main(string[] args)


        {

			// ikisinide bankaccount seklinde tanımlayarak polimorfizmide kullanmıs olduk
			BankAccount savingsAccount = new SavingsAccount
			{
				AccountHolder = "Muhammed İnan",
				Balance = 1000
			};

			BankAccount checkingAccount = new CheckingAccount
			{
				AccountHolder = "Engin Demiroğ",
				Balance = 2000
			};

			savingsAccount.CalculateInterest();
			checkingAccount.CalculateInterest();
		}
    }
}
