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

            ascii_logo ascii = new ascii_logo();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Title = "LUNO CHATBOT";   
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.WriteLine("                               LUNO CYBERSECURITY CHATBOT          ");
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.WriteLine("\n\n\n");

            //instantiating the classes
            voice_greeting voice_intro = new voice_greeting();
                
            welcome_and_username user = new welcome_and_username();

            //calling the methods
            user.welcome_and_collect();
         


        }//end of main
    }//end of class
}//end of namespace
