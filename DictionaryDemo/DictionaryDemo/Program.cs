using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			Dictionary<string, string> capitals = new Dictionary<string, string>();
			capitals.Add("Alabama", "Montgomery");
			capitals.Add("Alaska", "Juneau");
			capitals.Add("Arizona", "Phoenix");

			//to extract a value from the dictionary i use square brackets
			//and put in the key, rather than the value
			string capitalOfArizona = capitals["Arizona"];
			Console.WriteLine("The capital of Arizona is {0}", capitalOfArizona);
			*/

			var theStates = State.GetStates();
			//string capitalOfAlaska = theStates["Alaska"].Capital;
			var theState = theStates["Alaska"];
			Console.WriteLine("The capital of Alaska is {0}", theState.Capital);
		}
	}
}
