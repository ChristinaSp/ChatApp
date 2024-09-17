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
        private string _userName;
        private string _userIcon;
        private ObservableCollection<Message> _messages;
        private bool _hasUnreadMessages;

        public Chat(string name,string icon, ObservableCollection<Message> messages, bool hasUnreadMessages=false)
        {
            _hasUnreadMessages = hasUnreadMessages;
            _userName = name;
             _messages = messages;
            _userIcon = icon;
        }
        public string UserName { get => _userName; set => _userName = value; }
        public string UserIcon { get => _userIcon; set => _userIcon = value; }
        public ObservableCollection<Message> Messages { get => _messages; set => _messages = value; }
        public bool HasUnreadMessages { get => _hasUnreadMessages; set => _hasUnreadMessages = value; }

    }
}
