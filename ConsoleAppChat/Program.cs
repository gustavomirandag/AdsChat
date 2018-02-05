using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatLibrary.Services;
using ChatLibrary.Models;

namespace ConsoleAppChat
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageManager.AddMessage(new Message("Xande", "Comprem Bitcoins"));
            MessageManager.AddMessage(new Message("Java Guy", "Java é melhor que C#"));

            foreach (var message in MessageManager.GetAllMessages())
                Console.WriteLine($"{message.Sender}: {message.Content}");

            Console.ReadLine();
        }
    }
}
