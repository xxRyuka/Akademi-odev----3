using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademi_3
{
    class Manager : Employee
    {
		public int teamSize{ get; set; }

		public override void CalculateBonus()
		{
			double prim = this.Salary * 0.2;
			Console.WriteLine(prim);

			this.Salary += prim;
		}
	}
}
