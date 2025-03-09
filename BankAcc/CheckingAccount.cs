using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcc
{
    class CheckingAccount : BankAccount
    {
		public override void CalculateInterest()
		{
			Console.WriteLine("Vadesiz Hesaplar faiz kazandirmiyor :((");
		}
	}
}
