using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cybersecurityapp
{//start of namespace
    internal class Program
    {//start of class
        public static void Main(string[] args)
        {//start of main
            //instantiating the voice and logo classes
            //voice_greeting voice = new voice_greeting();
            ascii_logo ascii = new ascii_logo();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Title = "LUNO CHATBOT";
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.WriteLine("                               LUNO CYBERSECURITY CHATBOT          ");
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.WriteLine("\n\n\n");

            //instantiating the classes
            welcome_and_username user = new welcome_and_username();
            Chatbot chat = new Chatbot();

            //calling the welcome and username method
            user.welcome_and_collect();

            while (true)
            {
                //prompting the user for input and displaying the chatbot response
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nLUNO: What would you like to know about cybersecurity?");
                string userInput = Console.ReadLine();

                //calling the chatbot response method
                string response = chat.GetResponse(userInput);
                Console.WriteLine(response);
                Console.WriteLine("You: ");
            }

        }//end of main
    }//end of class
}//end of namespace
