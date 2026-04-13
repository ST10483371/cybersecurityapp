using System;
using System.Xml.Linq;

namespace cybersecurityapp
{
    internal class welcome_and_username
    {
        public void welcome_and_collect()
        {
            
            Console.WriteLine("Hi! I'm Luno Chatbot, your go to for everything cybersecurity awareness!" + "\n");
            Console.WriteLine("So, lets start by introducing yourself. What's your name?" + "\n");
            string name = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("It seems you didn't enter a name. Please try again." + "\n");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("\n");
            Console.WriteLine("Nice to meet you, " + name + "!" + "\n");
            Console.ReadLine();
        }
    }
}