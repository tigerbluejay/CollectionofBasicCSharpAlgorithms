using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionofBasicCSharpAlgorithms
{
	public static partial class Collection
	{
		public static void IntisNotDivisibleby3or7()
		{
			int number = 23; // Replace with the number you want to check

			bool notDivisibleBy3Or7 = IsNotDivisibleBy3Or7(number);

			if (notDivisibleBy3Or7)
			{
				Console.WriteLine($"{number} is not divisible by both 3 and 7.");
			}
			else
			{
				Console.WriteLine($"{number} is divisible by either 3 or 7.");
			}
		}

		static bool IsNotDivisibleBy3Or7(int n)
		{
			// Check if the number is not divisible by both 3 and 7
			return (n % 3 != 0) && (n % 7 != 0);
		}
	}
}
