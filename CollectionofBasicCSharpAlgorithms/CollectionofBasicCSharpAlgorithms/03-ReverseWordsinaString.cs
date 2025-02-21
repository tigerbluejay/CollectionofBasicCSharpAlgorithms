using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionofBasicCSharpAlgorithms
{
	public static partial class Collection
	{
		public static void ReverseWordsinaString()
		{
			string input = "Hello World";

			string[] words = input.Split(' ');

			Array.Reverse(words);

			string reversedString = string.Join(" ", words);

			Console.WriteLine(reversedString);

		}
	}
}
