using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionofBasicCSharpAlgorithms
{
	public static partial class Collection
	{
		public static void FindStringSubstring()
		{
			string input = "Hello, World!";

			// Find a substring starting at a specific index
			int startIndex = 7; // Index of 'W'
			string substring1 = input.Substring(startIndex);
			Console.WriteLine(substring1); // Outputs "World!"

			// Find a substring with a specified length
			int length = 5;
			string substring2 = input.Substring(startIndex, length);
			Console.WriteLine(substring2); // Outputs "World"
		}
	}
}