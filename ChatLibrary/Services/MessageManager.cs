using ChatLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatLibrary.Services
{
    public static class MessageManager
    {
        private static List<Message> messages = new List<Message>();

        public static void AddMessage(Message message)
        {
            messages.Add(message);
        }

        public static List<Message> GetAllMessages()
        {
            return messages;
        }
    }
}
