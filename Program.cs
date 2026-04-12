using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cybersecurityapp
{//start of namespace
    internal class Program
    {//start of class
        static void Main(string[] args)
        {//start of main
            
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.WriteLine("                               LUNO CYBERSECURITY CHATBOT          ");
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.WriteLine("\n\n\n");
            voice_greeting voice_intro = new voice_greeting();
            welcome_and_username user = new welcome_and_username();
            user.welcome_and_collect();
                        

        }//end of main
    }//end of class
}//end of namespace
