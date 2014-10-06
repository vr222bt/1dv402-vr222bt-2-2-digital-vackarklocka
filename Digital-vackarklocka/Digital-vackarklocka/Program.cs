using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_vackarklocka
{
    class Program
    {
        static void Main(string[] args)
        {
            AlarmClock test = new AlarmClock(13, 14, 13, 20);
            Run(test, 13);
            
            //Testar lite:
            //AlarmClock test = new AlarmClock(9, 55, 10, 0);

            //for (int i = 0; i < 10; i++)
            //{
                
            //    if (test.TickTock())
            //    {
            //        Console.WriteLine("{0} Tuut tuut tuut", test);
            //    }
            //    else
            //    {
            //        Console.WriteLine(test);
            //    } 
            //}
        }

        private static string HorizontalLine = "══════════════════════════════════════════════════════════════════════════════════════";
        

        private static void Run(AlarmClock ac, int minutes)
        {
            for (int i = 0; i < minutes; i++)
            {
                if (ac.TickTock())
                {
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.Write("♫");
                    Console.Write(ac.ToString());
                    Console.WriteLine("  RING RING RING RING");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(ac);
                }
            }

        }

        private static void ViewErrorMessage(string message)
        {

        }

        private static void ViewTestHeader(string header)
        {

        }

                                 
    }
}
