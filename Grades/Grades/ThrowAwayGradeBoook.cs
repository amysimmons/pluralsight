using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
	public class ThrowAwayGradeBoook : GradeBook
	{
		public ThrowAwayGradeBoook(string name)
			:base(name)
		{
			Console.WriteLine("throwaway ctor");
		}

		//override my base class implementation
		public override GradeStatistics ComputeStatistics()
		{
			float lowest = float.MaxValue;
			foreach (float grade in _grades)
			{
				lowest = Math.Min(lowest, grade);
			}
			_grades.Remove(lowest);
			return base.ComputeStatistics();
		}
	}


}
