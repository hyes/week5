using System;

namespace week5lab5
{
	class MainClass
	{
		public static void Main (string[] args)
		{ Console.WriteLine ("Sausage\tBun\tKetchup\tMustard\tOnions");
			for (int a = 0; a <= 1; a++)
				for (int b = 0; b <= 1; b++)
					for (int c = 0; c <= 1; c++)
						for (int d = 0; d <= 1; d++)
							for (int e = 0; e <= 1; e++)
							
								//Console.WriteLine("a \t b \t c \t d \t e");
								Console.WriteLine ("{0}\t{1}\t{2}\t{3}\t{4}", a, b, c, d, e);
		}
	}
}
