using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionofBasicCSharpAlgorithms
{
    public static partial class Collection
    {
		public static void SortArrayinDescendingOrder() { 

			int[] numbers = { 5, 2, 9, 1, 5, 6 };

			// Sort the array in descending order
			Array.Sort(numbers, (a, b) => b.CompareTo(a));

			// Print the sorted array
			foreach (var number in numbers)
			{
				Console.WriteLine(number);
			}
		}
	}
}
