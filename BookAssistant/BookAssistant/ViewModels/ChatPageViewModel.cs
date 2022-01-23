using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using BookAssistant.Models;
using Xamarin.Forms;
using BookAssistant.Views.Partials;
using BookAssistant;
using BookAssistant.BookController;
using System.Threading;
using System.Threading.Tasks;

namespace BookAssistant.ViewModels
{
    public class ChatPageViewModel: INotifyPropertyChanged
    {
        GetListBooks arg;
        public bool ShowScrollTap { get; set; } = false;
        public bool LastMessageVisible { get; set; } = true;
        public int PendingMessageCount { get; set; } = 0;
        public bool PendingMessageCountVisible { get { return PendingMessageCount > 0; } }

        public Queue<Message> DelayedMessages { get; set; } = new Queue<Message>();
        public ObservableCollection<Message> Messages { get; set; } = new ObservableCollection<Message>();
        public string TextToSend { get; set; }
        public ICommand OnSendCommand { get; set; }
        public ICommand MessageAppearingCommand { get; set; }
        public ICommand MessageDisappearingCommand { get; set; }

        public ChatPageViewModel()
        {
            Messages.Insert(0, MessageList.listMessage[0]);
            Messages.Insert(0, MessageList.listMessage[1]);

            MessageAppearingCommand = new Command<Message>(OnMessageAppearing);
            MessageDisappearingCommand = new Command<Message>(OnMessageDisappearing);
            OnSendCommand = new Command(OnSendCommande);
           
        }

        async void OnSendCommande() {
            if (!string.IsNullOrEmpty(TextToSend))
            {
                Messages.Insert(0, new Message() { Text = TextToSend, User = App.User });
                List<ListBock> books = BController.GetBook(arg = BController.GetListBooks(), TextToSend);
                if (books != null)
                {
                    foreach (var book in books)
                    {
                        Messages.Insert(0, new Message() { Text = book.ToString(), User = null });
                    }
                }

                switch (TextToSend.ToLower())
                {
                    case "категорії":
                        Messages.Insert(0, MessageList.listMessage[2]);
                        break;
                    case "команди":
                        Messages.Insert(0, MessageList.listMessage[3]);
                        break;
                    case "розробники":
                        Messages.Insert(0, MessageList.listMessage[4]);
                        break;
                    case "пака":
                        Messages.Insert(0, MessageList.listMessage[5]);
                        TextToSend = string.Empty;
                        await Task.Run(() => Thread.Sleep(5000));
                        Environment.Exit(1);
                        break;
                    default:
                        if(books == null)
                        {
                            Messages.Insert(0, MessageList.listMessage[6]);
                        }    
                        break;
                }

                TextToSend = string.Empty;
            }

        }

        void OnMessageAppearing(Message message)
        {
            var idx = Messages.IndexOf(message);
            if (idx <= 6)
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    while (DelayedMessages.Count > 0)
                    {
                        Messages.Insert(0, DelayedMessages.Dequeue());
                    }
                    ShowScrollTap = false;
                    LastMessageVisible = true;
                    PendingMessageCount = 0;
                });
            }
        }

        void OnMessageDisappearing(Message message)
        {
            var idx = Messages.IndexOf(message);
            if (idx >= 6)
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    ShowScrollTap = true;
                    LastMessageVisible = false;
                });

            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
