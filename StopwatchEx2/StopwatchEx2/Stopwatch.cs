using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopwatchEx2
{
    class Stopwatch
    {
        private DateTime _startTime;
        private string _decision;


        public void Start()
        {
            Console.Write("\nPress enter to start the timer...");
            Console.ReadLine();

            _startTime = DateTime.Now;
        }

        public void Stop()
        {
            Console.WriteLine("\nOK! Now press enter again to stop the timer!");
            Console.ReadLine();
            
            TimeSpan elapsed = DateTime.Now - _startTime;

            Console.WriteLine("The elapsed time is: {0}s, {1}ms \n(Press enter...)", elapsed.Seconds, elapsed.Milliseconds);
            Console.ReadLine();
        }

        public bool GoAgain()
        {
            Console.WriteLine("Would you like to continue? Enter \"C\" to continue and \"Q\" to quit.");
            _decision = Console.ReadLine().ToUpper();

            while (_decision != "C" && _decision != "Q")
            {
                Console.Clear();
                Console.WriteLine("\nInvalid Answer: Please enter \"C\" to continue and \"Q\" to quit.");
                _decision = Console.ReadLine().ToUpper();
            }
                

            if (_decision == "Q")
            {
                Console.Clear();
                return false;
            }
            else
            {
                Console.Clear();
                return true;
            }
        }
    }
}
