using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Models
{
    internal class Message
    {    
        private string _content;
        private string _senderName;
        private string _senderIcon;
        private DateTime _sentTime;
        public Message(string content, string senderName = "", string senderIcon = "", DateTime dateTime =new DateTime())
        {
            _content = content;
            _senderName = senderName;
            _senderIcon = senderIcon;
            _sentTime = dateTime;
        }
        public string SenderName { get => _senderName; set => _senderName = value; }
        public string Content { get => _content; set => _content = value; }
        public string SenderIcon1 { get => _senderIcon; set => _senderIcon = value; }
        public DateTime SentTime1 { get => _sentTime; set => _sentTime = value; }
    }
}
