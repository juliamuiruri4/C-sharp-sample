using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            WriteLine("enter number");
            a = Convert.ToInt32(ReadLine());

            switch(a)
            {
                case 1:
            WriteLine("one");
            break;
                case 2:
                    WriteLine("two");
                    break;

                case 3:
                    WriteLine("three");
                    break;
                case 4:
                    WriteLine("four");
                    break;
                case 5:
                    WriteLine("five");
                    break;
                case 6:
                    WriteLine("six");
                    break;
                case 7:
                    WriteLine("seven");
                    break;
                case 8:
                    WriteLine("eight");
                    break;
                case 9:
                    WriteLine("nine");
                    break;
                case 10:
                    WriteLine("ten");
                    break;

                default:
                    WriteLine("Outside");
                    break;
            }

            ReadKey();

        }
    }
}
