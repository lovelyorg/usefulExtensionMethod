using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            if (1.In(1, 2))
                if (5.NotIn(new int[] { 1, 2 }))
                {
                    Console.WriteLine("ok");
                }
                else
                {
                    Console.WriteLine("-------error-------");
                }

            Console.Read();
        }
    }
}