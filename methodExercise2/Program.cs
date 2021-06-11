using System;

namespace methodExercise2
{
	class Program
	{
		public static int AddMethod(int num1, int num2)
		{
			Console.WriteLine("give me a number to add.");
			num1 = int.Parse(Console.ReadLine());
			Console.WriteLine("another number.");
			num2 = int.Parse(Console.ReadLine());

			int sum = num1 + num2;
			return sum;
		}

		public static int MultiplyMethod(int num1, int num2)
		{
			Console.WriteLine("give me a number to multiply.");
			num1 = int.Parse(Console.ReadLine());
			Console.WriteLine("another number.");
			num2 = int.Parse(Console.ReadLine());

			int product = num1 * num2;
			return product;
		}
		static void Main(string[] args)
		{
			int sumMain = AddMethod(0, 0);
			Console.WriteLine(sumMain);

			int productMain = MultiplyMethod(0, 0);
			Console.WriteLine(productMain);
		}
	}
}
