using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademi_3
{
    class Developer : Employee
    {
		public int About { get; set; }

		public override void CalculateBonus()
		{
			double prim = this.Salary * 0.1; // Maasin %10u kadar prim alacak
			Console.WriteLine(prim );
			this.Salary += prim;
		}
	}
}
