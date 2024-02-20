using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorClassOverload.Properties;

namespace VectorClassOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = Vector.TryParse("3;5", out v1);
            Vector v2 = Vector.TryParse("4;6", out v2);
            double s = 3;
            Console.WriteLine("{0},{1}", v1.X, v1.Y);
            Console.WriteLine("{0},{1}", v2.X, v2.Y);

            Console.WriteLine((v1 * v2));
            Console.WriteLine(v1 + v2);
            Console.WriteLine(v1 / s);
            Console.WriteLine(v1 * s);
            Console.WriteLine(v2 * s);
            Console.WriteLine(-v2);
            Console.WriteLine(+v1);


            Console.ReadLine();

        }
    }
}
