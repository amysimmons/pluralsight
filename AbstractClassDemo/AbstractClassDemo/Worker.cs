using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
	class Worker : Employee
	{
		//we must override giveRaise if we are going to implement a worker
		//this is because GiveRaise is an abstract method on the Employee class
		public override void GiveRaise()
		{
			Salary += Salary*0.03;
		}
	}
}
