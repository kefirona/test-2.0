using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Массив_со_случайным_элементом
{
    public class Odnomer
    {
        public static void printArray(int[] m, string format)
        {
            for (int j = 0; j < m.Length; j++)
                Console.Write(format, m[j]);
            Console.WriteLine();
        }
    }
}
