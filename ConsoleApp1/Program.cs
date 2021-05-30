using System;
using System.Numerics;

namespace ConsoleApp1
{
    static class Program
    {
        static void Main(string[] args)
        {
            Random random = new();
            Adder adder = new();
            Minuser minuser = new();
            Multiplier multiplier = new();
            Divider divider = new();

            Console.WriteLine("Действительные(+)" + adder.Process(22, 14));
            Console.WriteLine("Действительные(-)" + minuser.Process(22, 14));
            Console.WriteLine("Действительные(*)" + multiplier.Process(22, 14));
            Console.WriteLine("Действительные(/)" + divider.Process(22, 14));

            Console.WriteLine("Комплексные(+)" + adder.Process(new Complex(5, 6), new
            Complex(-1, 1)));
            Console.WriteLine("Комплексные(-)" + minuser.Process(new Complex(5, 6), new
            Complex(-1, 1)));
            Console.WriteLine("Комплексные(*)" + multiplier.Process(new Complex(5, 6), new
            Complex(-1, 1)));
            Console.WriteLine("Комплексные(/)" + divider.Process(new Complex(5, 6), new
            Complex(-1, 1)));

            Console.WriteLine("Кватернионы(+)" + adder.Process(new Quaternion(random.Next(), random.Next(), random.Next(), random.Next()),
            new Quaternion(random.Next(), random.Next(), random.Next(), random.Next())));
            Console.WriteLine("Кватернионы(-)" + minuser.Process(new Quaternion(random.Next(), random.Next(), random.Next(), random.Next()),
            new Quaternion(random.Next(), random.Next(), random.Next(), random.Next())));
            Console.WriteLine("Кватернионы(*)" + multiplier.Process(new Quaternion(random.Next(), random.Next(), random.Next(), random.Next()),
            new Quaternion(random.Next(), random.Next(), random.Next(), random.Next())));
            Console.WriteLine("Кватернионы(/)" + divider.Process(new Quaternion(random.Next(), random.Next(), random.Next(), random.Next()),
            new Quaternion(random.Next(), random.Next(), random.Next(), random.Next())));

            Console.WriteLine("По модулю(+)" + adder.ModProcess(41, 19, 17));
            Console.WriteLine("По модулю(-)" + minuser.ModProcess(41, 19, 17));
            Console.WriteLine("По модулю(*)" + multiplier.ModProcess(41, 19, 17));
            Console.WriteLine("По модулю(/)" + divider.ModProcess(41, 19, 17));
            Console.Read();
        }
    }
}
