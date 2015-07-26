using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
	public class GradeBook
	{
		/*
		//this is a default constructor, which doesn't take any parameters, so when someone initializesa  gradebook they don't have to pass in any parameters
		//GRadebook is a class, it's a blueprint for creating objects 
		public GradeBook()
			//on this object, call the other constructor which takes a name paramater
			//this is done to avoid repeating the 	//grades = new List<float>(); line 
			: this("No name")
		{
			//grades = new List<float>();
		}
		 * */

		//this is setting a default value when no name string is passed in
		public GradeBook(string name = "There is no name")
		{
			Name = name;
			_grades = new List<float>();
		}
		
		//adds a member that will allow me to add a grade to the gradebook
		public void AddGrade(float grade)
		{

			if (grade >= 0 && grade <= 100)
			{
				//adds to the grades collection the grade that is passed into the method 
				_grades.Add(grade);
			}

		}

		//this method retrurns an object of type GradeStatistics
		public GradeStatistics ComputeStatistics()
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

		public void WriteGrades(TextWriter textWriter)
		{
			textWriter.WriteLine("Grades:");
			foreach (float grade in _grades)
			{
				textWriter.WriteLine(grade);
			}
		}

		//this is a private field 
		private string _name;

		//this is a property 
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				if (String.IsNullOrEmpty(value))
				{
					throw new ArgumentException("Name cannot be null or empty");
				}
				if (_name != value)
				{
					var oldValue = _name;
					_name = value;
		
					//announce the name has changed
					if (NameChanged != null)
					{
						NameChangedEventArgs args = new NameChangedEventArgs();
						args.OldValue = oldValue;
						args.NewValue = value;
						NameChanged(this, args);
					}
				}
			}
		}

		//this delegate is now a piece of state that I am carrying around
		//and i can invoke 
		//delegate public NameChangedDelegate NameChanged; 
		public event NameChangedDelegate NameChanged; //event

		//this is a class member that represents state 
		//it creates a list of floating point numbers
		//this line declares a field in my program 
		//this field initializer, 
		//this list is effectivel a variable, but we call it a field because it is inside a class, and that's goign to remember or refer to the list of floating point numbers that represent our grades
		private List<float> _grades;


	}
}
