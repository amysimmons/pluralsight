using System;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
	[TestClass]
	public class StringHandlerTest
	{
		[TestMethod]
		public void InsertSpacesTes()
		{
			//arrange
			var source = "SonicScrewdriver";
			var expected = "Sonic Screwdriver";

			//act
			var actual = source.InsertSpaces();

			//assert 
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void InsertSpacesTestWithExistingSpace()
		{
			//arrange
			var source = "Sonic Screwdriver";
			var expected = "Sonic Screwdriver";

			//act
			var actual = source.InsertSpaces();

			//assert 
			Assert.AreEqual(expected, actual);
		}
	}
}
