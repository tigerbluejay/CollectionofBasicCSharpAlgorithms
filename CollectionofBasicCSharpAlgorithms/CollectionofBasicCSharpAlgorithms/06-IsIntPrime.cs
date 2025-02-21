using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionofBasicCSharpAlgorithms
{
	public static partial class Collection
	{
		public static void IsIntPrime()
		{
			int number = 17; // Replace with the positive integer you want to check

			bool isPrime = IsPrime(number);

			if (isPrime)
			{
				Console.WriteLine($"{number} is a prime number.");
			}
			else
			{
				Console.WriteLine($"{number} is not a prime number.");
			}
		}

		static bool IsPrime(int n)
		{
			if (n <= 1)
			{
				return false;
			}
			if (n <= 3)
			{
				return true;
			}
			if (n % 2 == 0 || n % 3 == 0)
			{
				return false;
			}

			for (int i = 5; i * i <= n; i += 6)
			{
				if (n % i == 0 || n % (i + 2) == 0)
				{
					return false;
				}
			}
			return true;
		}
	}
}
