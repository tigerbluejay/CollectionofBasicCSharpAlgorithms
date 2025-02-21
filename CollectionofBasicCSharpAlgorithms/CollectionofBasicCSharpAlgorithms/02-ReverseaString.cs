using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionofBasicCSharpAlgorithms
{
	public static partial class Collection
	{
		public static void ReverseaString()
		{

			string input = "Hello, World!";

			char[] charArray = input.ToCharArray();

			Array.Reverse(charArray);

			string reversedString = new string(charArray);

			Console.WriteLine(reversedString);

		}
    }
}
