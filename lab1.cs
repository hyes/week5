using System;

namespace week5lab1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			for (int a = 1; a<=5; a++) {
				for (int b = 0; b < a; b++)
					Console.Write ("*");
				Console.WriteLine ();
			}
		}
	}
}
