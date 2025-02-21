using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionofBasicCSharpAlgorithms
{
	public static partial class Collection
	{
		public static void SumofEvenIntsinArray()
		{

		int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

		int sumOfEvenNumbers = SumEvenNumbers(numbers);

		Console.WriteLine("Sum of Even Numbers: " + sumOfEvenNumbers);
		}

		static int SumEvenNumbers(int[] arr)
		{
			int sum = 0;

			foreach (int num in arr)
			{
				if (num % 2 == 0) // Check if the number is even
				{
					sum += num;
				}
			}
			return sum;
		}
	}
}
