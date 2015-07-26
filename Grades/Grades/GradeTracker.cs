using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
	
	public interface IGradeTracker
	{
		void AddGrade(float grade);
		GradeStatistics ComputeStatistics();
		void WriteGrades(TextWriter textWriter);
		string Name { get; set; }
		event NameChangedDelegate NameChanged; //event
		void DoSomething();
	}

	public abstract class GradeTracker : IGradeTracker
	{
		public abstract void AddGrade(float grade);
		public abstract GradeStatistics ComputeStatistics();
		public abstract void WriteGrades(TextWriter textWriter);

		public abstract void DoSomething();

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
		private string _name;

	}
}
