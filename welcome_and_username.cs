using System;
using System.Diagnostics.Eventing.Reader;
using System.Xml.Linq;

namespace cybersecurityapp
{
    internal class welcome_and_username
    {
        public void welcome_and_collect()
        {
            //main welcome message and username collection
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Chatbot.TypeText("I'm Luno Chatbot, your go to for everything cybersecurity awareness!" + "\n");
            Chatbot.TypeText("What's your name?" + "\n");
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You: ");
            string name = Console.ReadLine();

            // Validate the username input
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Chatbot.TypeText("It seems you didn't enter a name. Please try again." + "\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("You: ");
                name = Console.ReadLine();
            }
            
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Chatbot.TypeText("LUNO: Nice to meet you, " + name + "!");
        }

    }
}