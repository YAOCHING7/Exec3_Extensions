using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string value = "0123456789";

			string result = value.Left(5);
			Console.WriteLine(result);

		}
	}
	public static class StringLeft
	{
		public static string Left(this string source, int length)
		{
			if (string.IsNullOrEmpty(source)) return string.Empty;
			if (length <= 0) return string.Empty;
			if (source.Length <= length) return source;

			return source.Substring(0, length);
		}
	}
}
