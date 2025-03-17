using System;

namespace Ds_Array_Ex
{
    // Array of DataStructure
    class ArrayExample 
	{
		static void Main(string[] args)
		{
			int[] numbers = { 10, 20, 30, 40, 50 };

			
			Console.WriteLine("for loop를 이용한 array[] 출력: ");
			for (int i = 0; i < numbers.Length; i++)
			{
				Console.WriteLine($"Index {i}: {numbers[i]}");
			}


			Console.WriteLine("\nforeach loop를 이용한 array[] 출력: ");
			foreach (int num in numbers)
			{
				Console.WriteLine(num);
			}
		}
	}
}
