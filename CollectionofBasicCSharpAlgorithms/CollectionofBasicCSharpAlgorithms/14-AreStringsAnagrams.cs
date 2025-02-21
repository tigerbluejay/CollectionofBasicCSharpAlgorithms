using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionofBasicCSharpAlgorithms
{
	public static partial class Collection
	{
		public static void AreStringsAnagrams()
		{
			string word1 = "listen";
			string word2 = "silent";

			bool areAnagrams = AreAnagrams(word1, word2);

			if (areAnagrams)
			{
				Console.WriteLine($"{word1} and {word2} are anagrams.");
			}
			else
			{
				Console.WriteLine($"{word1} and {word2} are not anagrams.");
			}
		}

		static bool AreAnagrams(string word1, string word2)
		{
			// Remove spaces and convert to lowercase (optional)
			word1 = word1.Replace(" ", "").ToLower();
			word2 = word2.Replace(" ", "").ToLower();

			// Check if the lengths are different; if so, they cannot be anagrams
			if (word1.Length != word2.Length)
			{
				return false;
			}

			// Sort the characters in both words and compare them
			char[] chars1 = word1.ToCharArray();
			char[] chars2 = word2.ToCharArray();

			Array.Sort(chars1);
			Array.Sort(chars2);

			for (int i = 0; i < chars1.Length; i++)
			{
				if (chars1[i] != chars2[i])
				{
					return false;
				}
			}

			return true;
		}
	}
}
