using System;

namespace week5lab4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			do {
				Console.Write ("Enter the operation[+, -, *, /](If you want to quit, enter 'q'): ");
				string operator1 = Console.ReadLine ();

				if (operator1 == "q") {
					break;
				}

				else if (operator1 != "+" && operator1 != "-" && operator1 != "*" && operator1 != "/"){
					Console.WriteLine("You entered wrong operation. Only +,-,*,/,q are allowed!");
					Console.WriteLine();
				}


				else
				{
					Console.Write ("Enter the first number : ");
					int num1 = int.Parse (Console.ReadLine ());
					Console.Write ("Enter the second number : ");
					int num2 = int.Parse (Console.ReadLine ());

					switch (operator1) {
					case "+":
						Console.WriteLine ("계산 결과: {0}", num1 + num2);
						Console.WriteLine ();
						break;
					case "-": 
						Console.WriteLine ("계산 결과: {0}", num1 - num2);
						Console.WriteLine ();
						break;
					case "*": 
						Console.WriteLine ("계산 결과: {0}", num1 * num2);
						Console.WriteLine ();
						break;
					case "/": 
						Console.WriteLine ("계산 결과: {0}", num1 / num2);
						Console.WriteLine ();
						break;
					}
				}
			} while(true);
			Console.WriteLine("BYE!");
		}

	}

}