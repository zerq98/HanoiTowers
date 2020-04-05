using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiTowers
{
    class Program
    {
        static void Main(string[] args)
        {
            Hanoi(5, 'A', 'B', 'C');
            Console.ReadLine();
        }

        private static void Hanoi(int n, char A, char B, char C)
        {
            if (n > 0)
            {
                Hanoi(n - 1, A, C, B);
                Console.WriteLine($"{A}->{B}");
                Hanoi(n - 1, B, A, C);
            }
        }
    }
}
