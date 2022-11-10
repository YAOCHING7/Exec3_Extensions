using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bool result = 99.IsOdd();
			Console.WriteLine(result);

			bool result1 = 99.IsEven();
			Console.WriteLine(result1);
		}

	}
	public static class MyMath
	{
		public static bool IsOdd(this int source)
		{
			return source % 2 == 1;
		}
		public static bool IsEven(this int source)
		{
			return source % 2 == 0;
		}
	}

}
}
