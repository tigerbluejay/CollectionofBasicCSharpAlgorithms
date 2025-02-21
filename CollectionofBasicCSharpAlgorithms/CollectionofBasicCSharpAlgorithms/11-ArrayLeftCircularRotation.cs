using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionofBasicCSharpAlgorithms
{
	public static partial class Collection
	{
		public static void ArrayLeftCircularRotation()
		{
		
		int[] arr = { 1, 2, 3, 4, 5 };
		int rotations = 2; // Number of left circular rotations

		int[] rotatedArray = LeftCircularRotate(arr, rotations);

		Console.WriteLine("Original Array: " + string.Join(", ", arr));
		Console.WriteLine("Rotated Array: " + string.Join(", ", rotatedArray));
		}

		static int[] LeftCircularRotate(int[] arr, int rotations)
		{
			int length = arr.Length;
			int[] rotatedArray = new int[length];

			for (int i = 0; i < length; i++)
			{
				int newPosition = (i - rotations + length) % length;
				rotatedArray[newPosition] = arr[i];
			}

			return rotatedArray;
		}

	}
}
