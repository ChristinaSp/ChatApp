using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Models
{
    internal class Chat
    {
        private User _user; 
        private ObservableCollection<Message> _messages;
        private bool _hasUnreadMessages;

        public Chat(User user,ObservableCollection<Message> messages, bool hasUnreadMessages=false)
        {
            _hasUnreadMessages = hasUnreadMessages;
            _user = user;
             _messages = messages;
             
        }
        public User User { get => _user; set => _user = value; } 
        public ObservableCollection<Message> Messages { get => _messages; set => _messages = value; }
        public bool HasUnreadMessages { get => _hasUnreadMessages; set => _hasUnreadMessages = value; }

    }
}
