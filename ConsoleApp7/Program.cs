using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedExample
{ 

    internal class Program
    {

        static void Main(String[] args)
        {
            int i, j;
            for (i = 0; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j + "");

                }
                Console.WriteLine();
            }

        }

    }
}

