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

        public MainWindowViewModel()
        {
            _messages = new ObservableCollection<Message>();

        }
        #region Properties
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
