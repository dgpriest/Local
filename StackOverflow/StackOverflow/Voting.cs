using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    class Voting
    {

        
        private int _totalVotes;

        public void UpDown()
        {
            Console.WriteLine("\nPlease rate this post: \nEnter \"U\" to up-vote and \"D\" to down-vote.");
            string vote = Console.ReadLine().ToUpper();


            while(vote != "U" && vote != "D")
            {
                Console.WriteLine("Invalid Answer: Please enter \"U\" to up-vote and \"D\" to down-vote.");
                Console.WriteLine("If you prefer, press \"Q\" to quit.");
                vote = Console.ReadLine().ToUpper();
                
                if(vote == "Q")
                    KillIt();
            }

            if (vote == "U")
            {
                _totalVotes = _totalVotes + 1;
            }

            else if (vote == "D" && _totalVotes > 0)
            {
                _totalVotes = _totalVotes - 1;
            }
            else
                return;

            Console.Clear();
        }


        public void DisplayVotes()
        {
            Console.WriteLine("The total votes for this post are: {0}",_totalVotes);
        }


        public void KeepGoing()
        {
            Console.WriteLine("\nWould you like to continue voting? Enter \"Y\" to continue or \"N\" to leave.");
            string perhaps = Console.ReadLine().ToUpper();

            while (perhaps != "Y" && perhaps != "N")
            {
                Console.WriteLine("Invalid Ansver: Please Enter \"Y\" to continue or \"N\" to leave.");
                perhaps = Console.ReadLine().ToUpper();
            }
            if (perhaps == "Y")
                return;
            else
                KillIt();   
        }


        public void KillIt()
        {
            Environment.Exit(0);
        }
    }
}
