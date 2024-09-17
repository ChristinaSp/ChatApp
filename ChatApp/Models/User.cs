using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Models
{
    class User
    {
        private string _userName;
        private string _userIcon;
        
        public User(string name, string icon)
        { 
            _userName = name; 
            _userIcon = icon;
        }
        public string UserName { get => _userName; set => _userName = value; }
        public string UserIcon { get => _userIcon; set => _userIcon = value; }
    }
}
