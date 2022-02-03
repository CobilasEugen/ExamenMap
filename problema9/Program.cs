using System;

namespace problema9
{
    class Program
    {
        void ProdusVectorial(int[] vec1, int[] vec2)
        {
            double det1, det2, det3, colin;
            det1 = (vec1[1] * vec2[2] - vec2[1] * vec1[2]);
            det2 = (vec2[0] * vec1[2] - vec1[0] * vec2[2]);
            det3 = (vec1[0] * vec2[1] - vec2[0] * vec1[1]);
            if (det1 < 0)
            {
                Console.Write($"VProdus = -{-det1}i");
            }
            else if (det1 > 0)
            {
                Console.Write($"VProdus = +{det1}i");
            }
            if (det2 < 0)
            {
                Console.Write($" - {-det2}j");
            }
            else if (det2 > 0)
            {
                Console.Write($" + {det2}j");
            }
            if (det3 < 0)
            {
                Console.WriteLine($" - {-det3}k");
            }
            else if (det3 > 0)
            {
                Console.WriteLine($" + {det3}k");
            }
            colin = det1 + det2 + det3;
            if (colin == 0)
            {
                Console.WriteLine("Vectorii sunt coliniari");
            }
            else
            {
                Console.WriteLine("Vectorii nu sunt coliniari");
            }

        }
        static double Aria(int[] vec1, int[] vec2)
        {
            double i,j,k;

            i = vec1[1] * vec2[2] - vec1[2] * vec2[0];
            j = vec1[2] * vec2[0] - vec1[0] * vec2[2];
            k = vec1[0] * vec2[1] - vec1[1] * vec2[0];

            return Math.Sqrt(Math.Pow(i,2) + Math.Pow(j,2) + Math.Pow(k,2));
        }

        static void Main(string[] args)
        {
            string line1 = "";
            string line2 = "";

            System.Console.WriteLine("Dati valori primului vector :");
            line1 = Console.ReadLine();

            System.Console.WriteLine("Dati valori primului vector :");
            line1 = Console.ReadLine();

            //calculeaza si produslul vectorial si testeaza coliniaritatea
            ProdusVectorial(Convert.ToCharArray(line1.Split(StringSplitOptions.RemoveEmptyEntries))
                , line2.Split(StringSplitOptions.RemoveEmptyEntries));

            // aria paralelogramului
            System.Console.WriteLine(Aria((Convert.ToCharArray(line1.Split(StringSplitOptions.RemoveEmptyEntries))
                , line2.Split(StringSplitOptions.RemoveEmptyEntries))));
        }
    }
}




