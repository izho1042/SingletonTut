using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonTut
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton a = Singleton.GetInstance();
            Singleton b = Singleton.GetInstance();

            if (ReferenceEquals(a, b))
            {
                Console.WriteLine("These are the same instance."); // Print the result to the console.
            }
            else
            {
                Console.WriteLine("These are different instances."); // Print the result to the console.
            }
            Console.ReadKey(); // Hold the console, until a key on the keyboard is inserted.
        }
    }
}
