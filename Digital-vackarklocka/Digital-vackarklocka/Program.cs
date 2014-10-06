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
            ViewTestHeader("Test 2\nTest av konstuktorn med två parametrar. (9, 42)");
            AlarmClock test2 = new AlarmClock(9, 42);
            Console.WriteLine(test2);

            //test 3
            ViewTestHeader("Test 3\nTest av konstruktorn med fyra parametrar. (13, 24, 7, 35)");
            AlarmClock test3 = new AlarmClock(13, 24, 7, 35);
            Console.WriteLine(test3);

            //test 4
            ViewTestHeader("Test 4\nStäller befintligt AlarmClock-object till 23:58 och låter den gå 13 minuter");
            Display();
            test3.Hour = 23;
            test3.Minute = 58;
            Run(test3, 13);

            //test 5
            ViewTestHeader("Test 5\nStäller befintligt AlarmClock-objekt till tiden 6:12 och alarmtiden till 6:15\noch låter den gå 6 minuter");
            Display();
            test3.Hour = 6;
            test3.Minute = 12;
            test3.AlarmHour = 6;
            test3.AlarmMinute = 15;
            Run(test3, 6);

            //test 6
            ViewTestHeader("Test 6\nTestar egenskaperna så att undantag kastas då tid och alarmtid tilldelas\nfelaktiga värden");
            AlarmClock test6 = new AlarmClock();
            try
            {
                test6.AlarmHour = 24;
            }
            catch (ArgumentException ex)
            {
               ViewErrorMessage(ex.Message);
            }
            try
            {
                test6.AlarmMinute = 60;
            }
            catch (ArgumentException ex)
            {
                ViewErrorMessage(ex.Message);
            }
            try
            {
                test6.Hour = 24;
            }
            catch (ArgumentException ex)
            {
                ViewErrorMessage(ex.Message);
            }
            try
            {
                test6.Minute = 60;
            }
            catch (ArgumentException ex)
            {
                ViewErrorMessage(ex.Message);
            }

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
            Console.WriteLine();
        }
        private static void Display()
        {
            //Lite utsmyckning
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" ╔═════════════════════════════════════════════╗ ");
            Console.WriteLine(" ║      Väckarklockan XT-002 Deconstructor     ║ ");
            Console.Write(" ║");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("    So tired. I will rest for just a moment! ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("║ ");
            Console.WriteLine(" ╚═════════════════════════════════════════════╝ ");
            Console.WriteLine();
            Console.ResetColor();
        }
                                 
    }
}
