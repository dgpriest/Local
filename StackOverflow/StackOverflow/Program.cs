using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            var post = new Post();
            var voting = new Voting();

            //Create and store header
            post.GetHeader();
            post.DisplayHeader();
                

            //Up-Vote or Down-Vote
            while(true)
            {
                voting.UpDown();

                voting.DisplayVotes();
                voting.KeepGoing();
            }   
        }

        

    }
}
