using System;
using System.Collections.Generic;
using _Command._Alexa;
using _Command.Commands;
using _Command.Lights;

namespace _Command
{
    class Program
    {
        private static void ConfigureAlexa(Alexa alexa)
        {
            var livingRoom = new PhilipsLight();
            var kitchen = new XiaomiLight();

            alexa.AddIntegration(
                "Ligue a luz da sala",
                new TurnLightOnCommand(livingRoom),
                new List<string> { "ligue", "ligar", "acenda", "acende", "acender", "sala", "luz", "lampada" });

            alexa.AddIntegration(
                "Desligue a luz da sala",
                new TurnLightOffCommand(livingRoom),
                new List<string> { "desligue", "desligar", "apague", "apagar", "sala", "luz", "lampada" });

            alexa.AddIntegration(
                "Ligue a luz da cozinha",
                new TurnLightOnCommand(kitchen),
                new List<string> { "ligue", "ligar", "acenda", "acender", "cozinha", "luz", "lampada" });

            alexa.AddIntegration(
                "Desligue a luz da cozinha",
                new TurnLightOffCommand(kitchen),
                new List<string> { "desligue", "desligar", "apague", "apagar", "cozinha", "luz", "lampada" });
        }

        static void Main(string[] args)
        {
            var alexa = new Alexa();
            ConfigureAlexa(alexa);

            Console.WriteLine("Olá, eu sou Alexa.");
            Console.WriteLine("Estou programada para ligar e/ou desligar a LUZ da SALA e da COZINHA");
            Console.WriteLine("O que você quer que eu faça? Eu já conheço os comandos abaixo:");
            Console.WriteLine("===============================");
            Console.WriteLine("Ligue a luz da sala");
            Console.WriteLine("Desligue a luz da sala");
            Console.WriteLine("Ligue a luz da cozinha");
            Console.WriteLine("Desligue a luz da cozinha");
            Console.WriteLine("===============================");

            //alexa.SendRequest("teste");

            while (true)
            {
                string phrase = Console.ReadLine();
                alexa.SendRequest(phrase);
            }
        }
    }
}
