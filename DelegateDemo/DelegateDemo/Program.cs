using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//a deleagte is a reference to a method
//its a way of passing a method as an argument to another method
//this allows you to decide which method to call at runtime

namespace DelegateDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			var tester = new MediaTester();
			var mp3 = new MP3Player();
			var mp4 = new MP4Player();

			var mp3Delegate = new MediaTester.TestMedia(mp3.PlayMP3File);
			var mp4Delegate = new MediaTester.TestMedia(mp4.PlayMP4File);

			tester.RunTest(mp3Delegate);
			tester.RunTest(mp4Delegate);

		}
	}
}
