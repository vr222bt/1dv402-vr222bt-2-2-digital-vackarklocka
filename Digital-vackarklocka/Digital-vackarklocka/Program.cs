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
            //Testar lite med det här när jag ändrar i koden
            try
            {
                AlarmClock test = new AlarmClock(0, 14, 0, 20);
                Run(test, 13);
            }
            catch (ArgumentException ex)
            {

                ViewErrorMessage(ex.Message);
            }
            //test 1
            ViewTestHeader("Test 1\nTest av standardkonstuktorn");
            AlarmClock test1 = new AlarmClock();
            Console.WriteLine(test1);

            //test 2
            ViewTestHeader("Test 2\nTest av konstuktornmed två parametrar. (9, 42)");
            AlarmClock test2 = new AlarmClock(9, 42);
            Console.WriteLine(test2);

            
            
        }

        private static string HorizontalLine = "═══════════════════════════════════════════════════════════════════════════════";
        

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
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void ViewTestHeader(string header)
        {
            Console.WriteLine(HorizontalLine);
            Console.WriteLine(header);
        }

                                 
    }
}
