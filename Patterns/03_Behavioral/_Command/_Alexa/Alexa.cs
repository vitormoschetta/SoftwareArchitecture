using System;
using System.Collections.Generic;
using System.Linq;
using _Command.Commands;

namespace _Command._Alexa
{
    public class Alexa
    {
        private Dictionary<string, ICommand> integrations;
        private AlexaAI ai;

        public Alexa()
        {
            integrations = new Dictionary<string, ICommand>();
            ai = new AlexaAI();
        }

        public void AddIntegration(string key, ICommand command, List<string> keywords)
        {
            integrations.Add(key, command);
            ai.AddAssociation(key, keywords);
        }

        public void SendRequest(string request)
        {
            ICommand command = integrations.FirstOrDefault(x => x.Key == request).Value;

            if (command is null)
            {
                string key = ai.GetFindAssociations(request);

                if (key is null)
                {
                    Console.WriteLine("Desculpe, não posso realizar sua solicitação!");
                    return;
                }

                command = integrations.FirstOrDefault(x => x.Key.Contains(key)).Value;

                if (command is null)
                {
                    Console.WriteLine("Desculpe, não posso realizar sua solicitação!");
                    return;
                }
            }

            command.Execute();
        }
    }
}