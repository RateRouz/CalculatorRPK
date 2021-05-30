using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Multiplier : IProcess
    {
        public Multiplier() { }
        public dynamic Process(dynamic A, dynamic B)
        {
            return A * B;
        }
        public int ModProcess(int A, int B, int M)
        {
            return (A * B) % M;
        }
    }
}
