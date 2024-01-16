using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1;

            Console.WriteLine("Upisi neku recenicu");
            s1 = Console.ReadLine();

            string s2 = s1.Replace(" ", "_");
            Console.WriteLine(s2);
            Console.ReadKey();
           
            
        }
    }
}
