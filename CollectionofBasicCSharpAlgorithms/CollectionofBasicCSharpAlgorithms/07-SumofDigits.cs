using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionofBasicCSharpAlgorithms
{
	public static partial class Collection
	{
		public static void SumofDigits()
		{
			int number = 12345; // Replace with the positive integer for which you want to find the sum of digits

			int digitSum = SumOfDigits(number);

			Console.WriteLine($"The sum of digits in {number} is {digitSum}");
		}

		static int SumOfDigits(int n)
		{
			int sum = 0;

			while (n != 0)
			{
				int digit = n % 10; // Get the last digit
				sum += digit; // Add the digit to the sum
				n /= 10; // Remove the last digit from the number
			}

			return sum;
		}

	}
}
