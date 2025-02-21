using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionofBasicCSharpAlgorithms
{
	public static partial class Collection
	{
		public static void RemoveDuplicateChars()
		{

			string input = "programming";

			string result = RemoveDuplicates(input);

			System.Console.WriteLine($"Original String: {input}");
			System.Console.WriteLine($"String with Duplicates Removed: {result}");
		}

		static string RemoveDuplicates(string input)
		{
			string uniqueChars = "";

			foreach (char c in input)
			{
				if (uniqueChars.IndexOf(c) == -1)
				{
					uniqueChars += c;
				}
			}

			return uniqueChars;
		}
	}
}
