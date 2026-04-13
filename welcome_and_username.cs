using System;
using System.Diagnostics.Eventing.Reader;
using System.Xml.Linq;

namespace cybersecurityapp
{
    internal class welcome_and_username
    {
        public void welcome_and_collect()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hi! I'm Luno Chatbot, your go to for everything cybersecurity awareness!" + "\n");
            Console.WriteLine("So, lets start by introducing yourself. What's your name?" + "\n");
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You: ");
            string name = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("It seems you didn't enter a name. Please try again." + "\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("You: ");
                name = Console.ReadLine();
            }
            
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Nice to meet you, " + name + "!" + "\n");
            Console.ReadLine();
        }
    }
}