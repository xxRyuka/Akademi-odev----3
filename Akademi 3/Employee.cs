using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademi_3
{
    public class Employee
    {
		public int id { get; set; }

		public string Name { get; set; }

		public string Department { get; set; }

		public double Salary{ get; set; }


		public virtual void CalculateBonus()
		{

		}
		
	}
}
