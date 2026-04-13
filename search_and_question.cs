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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("LUNO: I'm here to help you with any cybersecurity questions you may have. Just ask away!" + "\n");
            responses = new Dictionary<string[], string>
            {
                // Basic greetings
                { new string[] { "hi", "hello", "hey", "greetings" }, "Hello! How can I assist you with cybersecurity today?" },
                // Common cybersecurity questions
                { new string[] { "what is phishing?", "explain phishing", "define phishing" }, "Phishing is a cyber attack that uses disguised emails or messages to trick individuals into revealing sensitive information." },
                { new string[] { "how to create a strong password?", "tips for strong passwords" }, "To create a strong password, use a mix of uppercase and lowercase letters, numbers, and special characters. Avoid using common words or personal information." },
                { new string[] { "what is malware?", "explain malware", "define malware" }, "Malware is malicious software designed to harm, exploit, or otherwise compromise the security of a computer system." },
                { new string[] { "how to protect against ransomware?", "ransomware protection tips" }, "To protect against ransomware, regularly back up your data, keep your software updated, and be cautious when opening email attachments or clicking on links." }
            }; // <-- Close the Dictionary initialization
        }

        // Move the method outside the constructor
        public string GetResponse(string userInput)
        {
            string bestResponse = "I'm sorry, I don't have an answer for that. Please try asking something else related to cybersecurity.";
            int bestScore = 0;
            userInput = userInput.ToLower();
            foreach (var entry in responses)
            {
                int score = 0;
                foreach (var keyword in entry.Key)
                {
                    if (userInput.Contains(keyword))
                    {
                        score++;
                    }
                }

                if (score > bestScore)
                {
                    bestScore = score;
                    bestResponse = entry.Value;
                }
            }
            return "I'm sorry, I don't have an answer for that. Please try asking something else related to cybersecurity.";
        }
    }
}