using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionofBasicCSharpAlgorithms
{
	public static partial class Collection
	{
		public static void CountofCharsinaString()
		{
			string input = "hello world";

			int[] charCount = CountCharacters(input);

			Console.WriteLine("Character counts:");
			for (int i = 0; i < 256; i++)
			{
				if (charCount[i] > 0)
				{
					char character = (char)i;
					Console.WriteLine($"'{character}': {charCount[i]}");
				}
			}
		}

		static int[] CountCharacters(string s)
		{
			int[] charCount = new int[256];

			foreach (char c in s)
			{
				charCount[c]++;
			}

			return charCount;
		}
	}
}
