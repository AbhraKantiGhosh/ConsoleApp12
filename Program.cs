using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom;
using System.IO;
using System.Runtime.CompilerServices;

namespace ConsoleApp12
{
    class Program
    {

        public delegate string MyDeletage();
        public delegate int FactDelegate(int n);
       
        public static void Main(string[] args)
        {
           


            FactDelegate d1 = delegate (int n)
            {
                int fact = 1;

                for (int i = 1; i <= n; i++)
                {
                    fact = fact * i;
                }
                return fact;
            };
           int res = d1(5);
            Console.WriteLine(res);

            Console.ReadLine();


        }




    }
    
   
}
