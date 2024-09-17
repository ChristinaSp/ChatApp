using ChatApp.Helpers;
using ChatApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChatApp
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        private ICommand _addMessageCommand;
        private ObservableCollection<Message> _messages;
        private Message _selectedMessage;
        private ObservableCollection<Chat> _chats;
        private Chat _selectedChat;
        private string _inputText;

        public MainWindowViewModel()
        {
            _messages = new ObservableCollection<Message>();
            _chats = new ObservableCollection<Chat>();
            _chats.Add(new Chat( new User("Drake", "pack://application:,,,/Icons/ChatPicturesExample.png"), new ObservableCollection<Message>()));
            _chats.Add(new Chat(new User("Filip", "pack://application:,,,/Icons/ChatPicturesExample1.png"), new ObservableCollection<Message>()));

            _chats.Add(new Chat(new User("Omego", "pack://application:,,,/Icons/ChatPicturesExample2.png"), new ObservableCollection<Message>()));

            _chats.Add(new Chat(new User("Freyp", "pack://application:,,,/Icons/ChatPicturesExample3.png"), new ObservableCollection<Message>()));
            SelectedChat = Chats.FirstOrDefault();
        }
        #region Properties

        public ObservableCollection<Chat>  Chats
        {
            get => _chats;
            set
            {
                _chats = value;
                RaisePropertyChanged();
            }
        }
        public ObservableCollection<Message> Messages
        {
            get => _messages;
            set
            {
                _messages = value;
                RaisePropertyChanged();
            }
        }
        public Message SelectedMessage
        {
            get => _selectedMessage;
            set
            {
                _selectedMessage = value;
                RaisePropertyChanged();
            }
        }
         
        public Chat SelectedChat
        {
            get => _selectedChat;
            set
            {
                _selectedChat = value;
                Messages = SelectedChat.Messages;
                InputText = null;
                RaisePropertyChanged();
            }
        }
         
        public string InputText
        {
            get => _inputText;
            set
            {
                _inputText = value;
                RaisePropertyChanged();
            }
        }
        #endregion
        public event PropertyChangedEventHandler? PropertyChanged;




        public ICommand AddMessageCommand => _addMessageCommand ?? (_addMessageCommand = new RelayCommand(
(param) =>

{ 
 if (InputText != null)
     Messages.Add(new Message(InputText));
}));
        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
