using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string value = "123";
			int number = value.ToInt(-1); // 若轉型失敗, 傳回-1
			Console.WriteLine(number);
		}
	}
	public static class StringExtensions
	{
		public static int ToInt(this string source, int defaultValue)
		{
			bool isInt = int.TryParse(source, out int number);

			return isInt ? number : defaultValue;
		}
	}
}
