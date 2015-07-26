using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
	public class GradeBook : GradeTracker
	{
		//this is setting a default value when no name string is passed in
		public GradeBook(string name = "There is no name")
		{
			Name = name;
			_grades = new List<float>();
		}
		
		//adds a member that will allow me to add a grade to the gradebook
		public override void AddGrade(float grade)
		{
			if (grade >= 0 && grade <= 100)
			{
				//adds to the grades collection the grade that is passed into the method 
				_grades.Add(grade);
			}
		}

		//this method retrurns an object of type GradeStatistics
		//because the method is virtual it will no longer determine the method right at compile time,  
		//it's going to let things go until run time to determine the correct method to invoke
		public override GradeStatistics ComputeStatistics()
		{
			GradeStatistics stats = new GradeStatistics();

			float sum = 0f;
			foreach (float grade in _grades)
			{
				stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
				stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
				sum += grade;
			}

			stats.AverageGrade = sum / _grades.Count;
			return stats;
		}

		public override void WriteGrades(TextWriter textWriter)
		{
			textWriter.WriteLine("Grades:");
			foreach (float grade in _grades)
			{
				textWriter.WriteLine(grade);
			}
		}

		public override void DoSomething()
		{
			
		}

		
		
		//protecyed means grades is avail to any code in this class, and any code in a derived class
		protected List<float> _grades;

	}
}
