using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueCollection
{
	class Program
	{
		static void Main(string[] args)
		{
			var myQueue = new Queue<int>();
			myQueue.Enqueue(100);
			int val = myQueue.Dequeue();
			Console.WriteLine("val: {0}", val);

			for (int i = 0; i < 50; i++)
			{
				myQueue.Enqueue(i);
			}

			foreach(int i in myQueue)
			{
				Console.WriteLine("{0}, ", i);
			}

			//dequeued value is 0 here because a queue is a first in first out list
			//and 0 was the first item added to the queue
			var whichValue = myQueue.Dequeue();
			Console.WriteLine("\nDequeued value: {0}", whichValue);
			whichValue = myQueue.Dequeue();
			Console.WriteLine("\nDequeued value: {0}", whichValue);
		}
	}
}

//a stack is virtually the same as a queue, but we would use push and pop
//instead of enqueue and dequeue 
//a stack is a last in first out collection 