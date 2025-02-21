using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionofBasicCSharpAlgorithms
{
	public static partial class Collection
	{
		public static void GenerateRandomNumber()
		{
			// Create a Random object
			Random random = new Random();

			// Generate a random integer between 1 and 100 (inclusive)
			int randomNumber = random.Next(1, 101);

			Console.WriteLine("Random Number: " + randomNumber);
		}
	}
}
