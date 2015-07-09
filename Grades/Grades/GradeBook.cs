using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
	public class GradeBook
	{
		//this is a default constructor, which doesn't take any parameters, so when someone initializesa  gradebook they don't have to pass in any parameters
		//GRadebook is a class, it's a blueprint for creating objects 
		public GradeBook()
		{
			grades = new List<float>();
		}
		
		//adds a member that will allow me to add a grade to the gradebook
		public void AddGrade(float grade)
		{

			if (grade >= 0 && grade <= 100)
			{
				//adds to the grades collection the grade that is passed into the method 
				grades.Add(grade);
			}

		}

		//this method retrurns an object of type GradeStatistics
		public GradeStatistics ComputeStatistics()
		{
			GradeStatistics stats = new GradeStatistics();

			float sum = 0f;

			foreach (float grade in grades)
			{
				stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
				stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
				sum += grade;
			}

			stats.AverageGrade = sum / grades.Count;
			return stats;
		}


		public string Name;

		//this is a class member that represents state 
		//it creates a list of floating point numbers
		//this line declares a field in my program 
		//this field initializer, 
		//this list is effectivel a variable, but we call it a field because it is inside a class, and that's goign to remember or refer to the list of floating point numbers that represent our grades
		private List<float> grades;
	}
}
