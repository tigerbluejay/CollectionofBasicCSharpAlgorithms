using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionofBasicCSharpAlgorithms
{
	public static partial class Collection
	{
		public static void IsStringPalindrome()
		{
			string input = "racecar";

			input = input.Replace(" ", "").ToLower();

			string reversed = ReverseString(input);

			bool isPalindrome = input.Equals(reversed);

			if (isPalindrome)
			{
				Console.WriteLine("The string is a palindrome.");
			}
			else
			{
				Console.WriteLine("The string is not a palindrome.");
			}
		}

		// Helper method to reverse a string
		static string ReverseString(string s)
		{
			char[] charArray = s.ToCharArray();
			Array.Reverse(charArray);
			return new string(charArray);
		}
	}
}

