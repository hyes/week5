using System;

namespace week5lab3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("AHOY! I'm the Dread Pirate Roberts, and I have a secret!");
			Console.WriteLine ("It is a number from 1 to 99. I'll give you 6 tries.");

			Random random = new Random ();
			int a = random.Next (1, 99);

			int check = 0;

			for (int i = 0; i < 6; i++) {

				Console.Write ("What's Your Guess? ");
				int num = int.Parse (Console.ReadLine ());

				if (num > a) {
					Console.WriteLine ("Too High!!!");
				} else if (num < a) {
					Console.WriteLine ("Too Low!!!");
				} else {
					Console.WriteLine ("You got it!!!");
					check = 1;
					break;
				}
			}

			if(check == 0)
			Console.WriteLine ("No more guess! Better luck next time");
		}
	}
}
