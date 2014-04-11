using System;

namespace week5lab2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			for (int a = 1; a <= 9; a++) {
				Console.WriteLine ("[{0}times table]", a);
				for (int b = 1; b <= 9; b++)
					Console.WriteLine ("{0} * {1} = {2}", a, b, a * b);
				Console.WriteLine ();
			}
		}
	}
}
