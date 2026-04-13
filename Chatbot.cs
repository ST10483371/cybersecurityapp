using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace cybersecurityapp
{
    public class Chatbot
    {
        private Dictionary<string[], string> responses;

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
            }; // <-- Close the Dictionary initialization
        }

        // Move the method outside the constructor
        public string GetResponse(string userInput)
        {
            string bestResponse = "I'm sorry, I don't have an answer for that. Please try asking something else related to cybersecurity.";
            int bestScore = 0;
            bool foundMatch = false;
            userInput = userInput.ToLower().Trim();

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

                if (score > bestScore)
                {
                    bestScore = score;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    bestResponse = "LUNO: " + entry.Value;
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("You: ");
                }
            }

            if (userInput.Contains("exit") || userInput.Contains("quit"))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nLUNO: Goodbye! Stay safe online!");
                Environment.Exit(0);
            }

            if (!foundMatch)
            {
                 Console.ForegroundColor = ConsoleColor.DarkYellow;
                 Console.WriteLine("\nLUNO: I'm sorry, I don't have an answer for that. Please try asking something else related to cybersecurity.");
                 Console.ForegroundColor = ConsoleColor.Cyan;
                 Console.WriteLine("You: ");
            }
            return bestResponse;
        }
    }
}