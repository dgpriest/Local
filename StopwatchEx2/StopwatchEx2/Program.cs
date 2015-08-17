using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopwatchEx2
{
    class Program
    {
        static void Main(string[] args)
        {

            bool againAndAgain = true;
            var dontBelieveMeJustWatch = new Stopwatch();
            
            while(againAndAgain)
            { 
                //Start timer
                dontBelieveMeJustWatch.Start();

                //Stop timer
                dontBelieveMeJustWatch.Stop();

                // check too see if user will continue...will run the test and input the boolean value in one shot!
                againAndAgain = dontBelieveMeJustWatch.GoAgain();
            }
        }
    }
}
