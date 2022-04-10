using System;
using System.Collections.Generic;
using quiz.domain.Contracts;

namespace quiz.infrastructure.Services
{
    public class MailerMemory : IMailer
    {
        private readonly IList<string> messages;

        public MailerMemory()
        {
            messages = new List<string>();
        }
        
        public void Send(string to, string message)
        {
            messages.Add($"{to} - {message}");
            Console.WriteLine($"Sending email to {to} with message {message}");
        }
    }
}