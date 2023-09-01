using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatchSwitvh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 0, op;

            Console.WriteLine("Enter a :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b :");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operator - (0,1,2,3) :");
            op = Convert.ToInt32(Console.ReadLine());

            try
            {
                switch (op)
                {
                    case 0: c = a + b; break;
                    case 1: c = a - b; break;
                    case 2: c = a * b; break;
                    case 3: c = a / b; break;
                }

                StreamWriter sw = new StreamWriter(@"D:\DOTNET\calculator.txt");

                sw.WriteLine(c);
                sw.Close();
            }
            catch (DivideByZeroException e1)
            {
                Console.WriteLine(e1.Message);
            }
            catch (FileNotFoundException e2)
            {
                Console.WriteLine(e2.Message);
            }

            Console.ReadLine();
           
        }
    }
}
