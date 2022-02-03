using System;

namespace problema10
{
    //problema 10
    class Program
    {
        public static long n;
        public static long m;
        public static long k;

        static void Main(string[] args)
		{
			Console.Write("n: ");
			n = int.Parse(Console.ReadLine(StringSplitOptions.RemoveEmptyEntries));
			Console.Write("m: ");
			m = int.Parse(Console.ReadLine(StringSplitOptions.RemoveEmptyEntries));
			Console.Write("nr min si nr max de noduri izolate: ");
			
			if (m * 2 >= n)
			{
				Console.Write(0);
				Console.Write(" ");
			}
			else
			{
				Console.Write(n - 2 * m);
				Console.Write(" ");
			}

			while (k * (k - 1) / 2 < m)
			{
				k++;
			}

			Console.Write(n - k);

			Console.WriteLine();
		}
	}
}
