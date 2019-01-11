using System;
using System.Collections;

namespace testgita
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            for (int i = 0; i < 100; i++)
                Console.Write(a.Add(i));
        }
    }
}
