using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatLibrary.Models
{
    public class Message
    {
        public String Sender { get; set; }
        public String Content { get; set; }

        public Message(string sender, string content)
        {
            Sender = sender;
            Content = content;
        }
    }
}
