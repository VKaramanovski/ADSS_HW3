using System;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

namespace ADSS_HW3
{
	class Program
	{
		static void Main(string[] args)
		{
            int a = 15;
            int b = 3;

            Console.WriteLine(BasicOp('+', a, b));
            Console.WriteLine(BasicOp('-', a, b));
            Console.WriteLine(BasicOp('*', a, b));
            Console.WriteLine(BasicOp('/', a, b));


            Console.WriteLine(ConvertToBin(1564, 22));


		}

		static string ConvertToBin(int a, int b)
		{
			int numToConvert = a + b;
			string binary = Convert.ToString(numToConvert, 2);
			return binary;
		}

		static int BasicOp(char c, int a, int b)
		{
			var operation = 0;

			switch (c)
			{
				case '+':
					operation = a + b;
					return operation;

				case '-':
					operation = a - b;
					return operation;

				case '*':
					operation = a * b;
					return operation;

				case '/':
					operation = a / b;
					return operation;
				default:
					Console.WriteLine("Wrong operation parameter!");
					return operation;
			}
		}
	}
}