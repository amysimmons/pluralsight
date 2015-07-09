using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grades;

namespace Grades.Tests
{
	[TestClass]
	public class GradeBookTests
	{
		[TestMethod]
		public void CalculatesHighestGrade()
		{
			GradeBook book = new GradeBook();
			book.AddGrade(90f);
			book.AddGrade(2f);
			book.AddGrade(100f);

			GradeStatistics stats = book.ComputeStatistics();

			Assert.AreEqual(100f, stats.HighestGrade);

			//Assert.IsTrue(value);
		}

		[TestMethod]
		public void PassByValue()
		{
			GradeBook book = new GradeBook();
			book.Name = "Hello World";
			SetName(book);

			Assert.AreEqual(book.Name, "Hello World");
		}

		void SetName(GradeBook book)
		{
			book.Name = "Hello World";
		}
	}
}

//you typically  have one assert method at the bottom of
//a test