using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            var strAAA = "AAA";
            if (strAAA.In("AAA", "BBB"))
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