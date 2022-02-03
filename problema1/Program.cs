using System;

namespace problema1
{
    //problema 17
    class Program
    {
        static void Main(string[] args)
        {
            int n,m;
            Console.WriteLine("dati valori lui n :");
            n = int.Parse(Console.ReadLine());
            
            Console.WriteLine("dati valori lui m :");
            m = int.Parse(Console.ReadLine());

            for (var i = 0; i <= n*m; i++)
            {
                Console.Write( ( 2 * ( i - 1 ) + 1 ) * ( 2 * ( i - 1 ) + 1 ) + " ");
                if(i % m == 0) Console.WriteLine();
            }
        }
    }
}
