using System.Data.Common;
using Xunit;

namespace xUnitTests.Tests
{
	public class CalculatorTests
	{
		[Fact]
		public void ShouldAdd()
		{
			//Arrange 
			//sut stands for system under test
			var sut = new Calculator();

			//Act 
			//The act phase exercises the thing that we are testing
			var result = sut.Add(5, 5);

			//Assert 
			//In the assert phase we check that the activites we performed in the act phase result in the expected outcome
			Assert.Equal(10, result);
		}
	}
}