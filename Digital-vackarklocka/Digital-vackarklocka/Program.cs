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
            
            AlarmClock test = new AlarmClock(9, 59, 10, 0);

            if (test.TickTock())
            {
                Console.WriteLine("{0} Tuut tuut tuut", test); 
            }
            else
            {
                Console.WriteLine(test);
            }
        }                         
    }
}
