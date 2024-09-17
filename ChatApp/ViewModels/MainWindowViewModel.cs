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

        public MainWindowViewModel()
        {
            _messages = new ObservableCollection<Message>();
            _chats = new ObservableCollection<Chat>();
            _chats.Add(new Chat("Drake", "C:\\Users\\Admin\\source\\repos\\ChatApp\\ChatApp\\Icons\\ChatPicturesExample.png", new ObservableCollection<Message>()));
            _chats.Add(new Chat("Filip", "C:\\Users\\Admin\\source\\repos\\ChatApp\\ChatApp\\Icons\\ChatPicturesExample1.png", new ObservableCollection<Message>()));

            _chats.Add(new Chat("Omego", "C:\\Users\\Admin\\source\\repos\\ChatApp\\ChatApp\\Icons\\ChatPicturesExample2.png", new ObservableCollection<Message>()));

            _chats.Add(new Chat("Freyp", "C:\\Users\\Admin\\source\\repos\\ChatApp\\ChatApp\\Icons\\ChatPicturesExample3.png", new ObservableCollection<Message>()));

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
        #endregion
        public event PropertyChangedEventHandler? PropertyChanged;




        public ICommand AddMessageCommand => _addMessageCommand ?? (_addMessageCommand = new RelayCommand(
(param) =>

{
 var newMassage = param?.ToString();
 if (newMassage != null)
     Messages.Add(new Message(newMassage));
}));
        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
