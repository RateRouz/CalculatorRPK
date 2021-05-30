using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Divider : IProcess
    {
        public Divider() { }
        public dynamic Process(dynamic A, dynamic B)
        {
            return A / B;
        }
        public int ModProcess(int A, int B, int M)
        {
            if (IsPrime(M))
            {
                return (A * InverseElement(B, M)) % M;
            }
            else return int.MaxValue;
        }
        private int BinPow(int basa, int p, int M)
        {
            if (p == 1)
            {
                return basa;
            }
            if (p % 2 == 0)
            {
                int t = BinPow(basa, p / 2, M);
                return t * t % M;
            }
            else
            {
                return BinPow(basa, p - 1, M) * basa % M;
            }

        }
        private int InverseElement(int x, int M)
        {
            return BinPow(x, M - 2, M);
        }
        private static bool IsPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
