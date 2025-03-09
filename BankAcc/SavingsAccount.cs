using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcc
{
    class SavingsAccount : BankAccount
    {
		public override void CalculateInterest()
		{
			double faiz = this.Balance * 0.05;
		}
	}
}
