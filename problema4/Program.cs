using System;
using  System.IO;
namespace problema4
{
    // problema 4
    class Program
    {
        static string stringResult = "";
        static int n;

		static int[] x = new int[9];
		static void Result()
		{
			for (int i = 1; i <= n; i++)
				stringResult += x[i] + " ";
			stringResult += '\n';
		}
		public static int valid(int k)
		{

			for (int i = 1; i < k; i++)
			{
				if (x[i] == x[k])
				{
					return 0;
				}
			}
			return 1;
		}
		public static void back(int k)
		{
			for (int i = n; i > 0; i--)
			{
				x[k] = i;
				if (valid(k) != 0)
				{
					if (k == n)
					{
						Result();
					}
					else
					{
						back(k + 1);
					}
				}
			}
		}
        static void Main(string[] args)
        {
            //foloses vs code si daca folosesti visual studio obisnuit tre sa modifici path in stream
            // reader sau writer
            // sau doar muti text file on bin \ obj\..
            using(StreamReader sr = new StreamReader("permutari1.in"))
            {
                char [] seps = {' ', '\n', '\t'};
                string line = sr.ReadLine();
                string [] tokens = line.Split(seps,StringSplitOptions.RemoveEmptyEntries);
                n = int.Parse(tokens[0]); 
            }
	        back(1);
            using(StreamWriter sw = new StreamWriter("permutari1.out"))
            {
                sw.WriteLine(stringResult);
            }
        }
    }
}
