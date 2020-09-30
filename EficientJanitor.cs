using System;

namespace EficientJanitor
{
	class Program
	{
		static void Main(string[] args)
		{
			double[] arr = { 1.01, 1.991, 1.32, 1.4 };

			int i = 0;
			int trips = 0;
			while (i < arr.Length)
			{
				double temporary = arr[i] + arr[i + 1];
				if (temporary < 3)
				{
					trips++;
					i += 2;
				}
				else
				{
					trips++;
					i += 1;
				}
			}
			Console.WriteLine(trips);
		}

	}
}
