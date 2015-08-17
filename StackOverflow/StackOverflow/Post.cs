using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    class Post
    {
        public string[,] answerA = new string[3,2];

        public void GetHeader()
        {
            answerA[0,0] = "Title: ";
            Console.WriteLine("What would you like to title this post?:");
            answerA[0,1] = Console.ReadLine();

            answerA[1,0] = "Description: ";
            Console.WriteLine("Please give us a short description of you post:");
            answerA[1,1] = Console.ReadLine();

            answerA[2,0] = "Date/Time of Posting: ";
            answerA[2,1] = DateTime.Now.ToString();
        }


        public void DisplayHeader()
        {
            Console.WriteLine();

            for (int i = 0; i <= 2; )
            {
                Console.WriteLine("{0}{1}", answerA[i, 0], answerA[i, 1]);
                i++;
            }
            Console.ReadLine();
        }
        
    }
}
