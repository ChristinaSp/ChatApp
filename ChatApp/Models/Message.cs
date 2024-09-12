using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Models
{
    internal class Message
    {
        private int _id;
        private string _content;
        private string _author;

        public Message(string content,int id=0,string autor="")
        {
            _content = content;
            _id = id;
            _author = autor;
        }
        public int Id { get => _id; set => _id = value; }
        public string Author { get => _author; set => _author = value; }
        public string Content { get => _content; set => _content = value; }
    }
}
