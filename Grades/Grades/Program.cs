using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
	class Program
	{
		static void Main(string[] args)
		{
			//I create a variable called book with a type of Gradebook here because from inside of this Program 
			//class I can use any other class that I have defined in this same project,
			//as well as types from the framework class library
			//new is a constructor method to create a new object, which is an instance of the class
			GradeBook book = new GradeBook();

			//AddGrade is available to be called on book because I have it defined as a member/method of my class 
			book.AddGrade(91f);
			book.AddGrade(89.5f);
			book.AddGrade(75.5f);
			 
			//this method will hide the algorithms thati need to compute the stats, it will encapsulate the methods that i need 
			GradeStatistics stats = book.ComputeStatistics();
			Console.WriteLine(stats.AverageGrade);
			Console.WriteLine(stats.HighestGrade);
			Console.WriteLine(stats.LowestGrade);

		/*
			GradeBook book2 = new GradeBook();
			book2.AddGrade(11f);
			book2.AddGrade(100f);

			GradeBook book3 = book2;
			book3.AddGrade(60f);
		*/
		}
	}
}
