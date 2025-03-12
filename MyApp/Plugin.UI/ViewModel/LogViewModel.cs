using CommunityToolkit.Mvvm.Collections;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using Plugin.UI.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.UI.ViewModel
{
    partial class LogViewModel : ObservableObject, IRecipient<ValueChangedMessage<Log>>
    {

        public LogViewModel()
        {
            Logs = new ObservableCollection<Log>();
            Logs.Add(new Log(LogType.Info, "This is a test log."));
            Logs.Add(new Log(LogType.Warning, "This is a test warning."));
            Logs.Add(new Log(LogType.Error, "This is a test error."));
        }

        [ObservableProperty]
        private ObservableCollection<Log>? logs;

        public void Receive(ValueChangedMessage<Log> message)
        {
            Logs?.Add(message.Value);
        }
    }
}
