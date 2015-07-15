using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Grades
{
	class Program
	{
		/*
		static void GiveBookAName(GradeBook book)
		{
			book.Name = "The GradeBook";
		}

		static void IncreementNumber(int number)
		{
			number += 1;
		}
		*/

		static void Main(string[] args)
		{
			
			//I create a variable called book with a type of Gradebook here because from inside of this Program 
			//class I can use any other class that I have defined in this same project,
			//as well as types from the framework class library
			//new is a constructor method to create a new object, which is an instance of the class
			
			GradeBook book = new GradeBook("Scott's book");

			//AddGrade is available to be called on book because I have it defined as a member/method of my class 
			book.AddGrade(91f);
			book.AddGrade(89.5f);
			book.AddGrade(75.5f);
			book.WriteGrades(Console.Out);
			  
			//this method will hide the algorithms that i need to compute the stats, it will encapsulate the methods that i need 
			GradeStatistics stats = book.ComputeStatistics();

			book.NameChanged += OnNameChanged;
			book.Name = "Allen's book";
			WriteBytes(stats.AverageGrade);
			
			Console.WriteLine(stats.AverageGrade);
			Console.WriteLine(stats.HighestGrade);
			Console.WriteLine(stats.LowestGrade);
			Console.WriteLine(stats.LetterGrade);

			book.Name = "";
			WriteNames(book.Name);

			/*
			GradeBook book2 = new GradeBook();
			book2.AddGrade(11f);
			book2.AddGrade(100f);

			GradeBook book3 = book2;
			book3.AddGrade(60f);
			*/

			//Arrays();

			//Immutable();
			//PassByValueAndRef();
		}

		private static void OnNameChanged(object sender, NameChangedEventArgs args)
		{
			Console.WriteLine("Name changed from {0} to {1}", args.OldValue, args.NewValue);
		}


		private static void WriteBytes(float value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			foreach (byte b in bytes)
			{
				Console.Write("0x{0:X}" , b);
			}
			Console.WriteLine();
		}

		//whenever you have params in front of the last parameter to a method
		//that means the caller can pass as many parameters as they want
		private static void WriteNames(params string[] names)
		{
			foreach (string name in names)
			{
				Console.WriteLine(name);
			}
		}

		/*
		private static void Arrays()
		{
			float[] grades = new float[3];

			AddGrades(grades);

			foreach(float grade in grades)
			{
				Console.WriteLine(grade);
			}
		}

		private static void AddGrades(float[] grades)
		{
			if (grades.Length >= 3)
			{
				grades[0] = 91f;
				grades[1] = 89.1f;
				grades[2] = 75f;
			}

		}

		private static void Immutable()
		{
			string name = " Scott ";
			name.Trim();

			string name2 = name.Trim();
			Console.WriteLine(name);
			Console.WriteLine(name2);


			DateTime date = new DateTime(2014, 1, 1);
			date = date.AddHours(25);

			Console.WriteLine(date);
		}

		private static void PassByValueAndRef()
		{
			GradeBook g1 = new GradeBook();
			GradeBook g2 = g1;

			GiveBookAName(g1);
			Console.WriteLine(g2.Name);


			int x1 = 4;
			IncreementNumber(x1);
			Console.WriteLine(x1);

			int x2 = x1;

			x1 = 100;
			Console.WriteLine(x2);
		}
		*/
	
	}

}
