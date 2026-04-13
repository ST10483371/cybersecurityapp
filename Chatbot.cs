using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace cybersecurityapp
{
    public class Chatbot
    {
        //creting a dictionary to hold the keywords and responses
        private Dictionary<string[], string> responses;

        //chatbot constructor to initialize the dictionary with keywords and responses
        public Chatbot()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            
            responses = new Dictionary<string[], string>
            {
                // Basic greetings
                { new string[] { "hi", "hello", "hey", "greetings" }, "Hello! How can I assist you with cybersecurity today?" },
                // Common cybersecurity questions
                { new string[] { "phishing", "scam", "email", "spam" }, "Phishing is a cyber attack that uses disguised emails or messages to trick individuals into revealing sensitive information." },
                { new string[] { "password" }, "To create a strong password, use a mix of uppercase and lowercase letters, numbers, and special characters. Avoid using common words or personal information." },
                { new string[] { "malware", "virus", "malicious", "trojan"}, "Malware is malicious software designed to harm, exploit, or otherwise compromise the security of a computer system." },
                { new string[] { "ransomware" }, "To protect against ransomware, regularly back up your data, keep your software updated, and be cautious when opening email attachments or clicking on links." }
            }; 
        }

        // method to get the chatbot response based on user input
        public string GetResponse(string userInput)
        {
            string bestResponse = "";
            int bestScore = 0;
            bool foundMatch = false;
            userInput = userInput.ToLower().Trim();

            //for loop to match the user input with the keywords in the dictionary and return the best response
            foreach (var entry in responses)
            {
                int score = 0;
                foreach (var keyword in entry.Key)
                {
                    if (userInput.Contains(keyword))
                    {
                        score++;
                        foundMatch = true;
                    }
                }

                //if to check if the current response has a higher score than the best score and update the best response accordingly
                if (score > bestScore)
                {
                    bestScore = score;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    bestResponse = "LUNO: " + entry.Value;
                    Console.WriteLine("\n");
                }
            }

            //if to check if the user wants to exit the chatbot and display a goodbye message before exiting
            if (userInput.Contains("exit") || userInput.Contains("quit"))
            {
                // Display a goodbye message before exiting
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nLUNO: Goodbye! Stay safe online!");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("*****************************************************************************");
                Environment.Exit(0);
            }

            //if to check if no match was found and display a default message if no match was found
            if (!foundMatch)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nLUNO: I'm sorry, I don't have an answer for that. Please try asking something else related to cybersecurity.");
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            return bestResponse;
        }

        //method to display the chatbot response with a typing effect
        public static void TypeText(string text, int delay = 30)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(delay);
            }
            Console.WriteLine();
        }
    }
}