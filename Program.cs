using System;

namespace Recursividade
{
	class Program
	{
		static void Main(string[] args)
		{
			double[] arr = { 1.01, 1.991, 1.32, 1.4 };
			Array.Sort(arr);
			var total = Sum(arr, 0) / 3;
		}

		static double Sum(double[] arr, int last)
		{
			if (last < arr.Length) return arr[last] + Sum(arr, last + 1);
			else return 0;
		}
	}
}
