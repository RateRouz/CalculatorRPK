using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IProcess
    {
        dynamic Process(dynamic A, dynamic B);
        int ModProcess(int A, int B, int M);
    }
}
