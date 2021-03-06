using BookAssistant;
using BookAssistant.Models;
using BookAssistant.Views.Cells;
using Xamarin.Forms;

namespace BookAssistant.Helpers
{
    class ChatTemplateSelector : DataTemplateSelector
    {
        DataTemplate incomingDataTemplate;
        DataTemplate outgoingDataTemplate;

        public ChatTemplateSelector()
        {
            this.incomingDataTemplate = new DataTemplate(typeof(IncomingViewCell));
            this.outgoingDataTemplate = new DataTemplate(typeof(OutgoingViewCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var messageVm = item as Message;
            if (messageVm == null)
                return null;

          
            return (messageVm.User == App.User)? outgoingDataTemplate: incomingDataTemplate;
        }

    }
}