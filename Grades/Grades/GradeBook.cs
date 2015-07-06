using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
	class GradeBook
	{
		//adds a member that will allow me to add a grade to the gradebook
		public void AddGrade(float grade)
		{
			//adds to the grades collection the grade that is passed into the method 
			grades.Add(grade);
		}
		//this is a class member that represents state 
		//it creates a list of floating point numbers
		//this line declares a field in my program 
		List<float> grades = new List<float>();
	}
}
