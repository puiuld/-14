using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pd2
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Vvod("n=");
            Func();
            Console.ReadLine();
            
        }
        public static string Vvod(string message)
        {
            Console.Write(message);
            return (Console.ReadLine());
        }
        public static void Func()
        {
            
            for (int x = 1; x<=n; x++)
            {
                
                Console.WriteLine(x);
            }
        }


    }
}
