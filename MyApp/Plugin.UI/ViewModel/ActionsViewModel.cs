using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using Plugin.UI.Model;
using static System.Net.Mime.MediaTypeNames;

namespace Plugin.UI.ViewModel
{
    partial class ActionsViewModel : ObservableObject
    {
        public ObservableCollection<SingleActionViewModel> Actions { get; }

        private Log Log { get; set; } = new Log(LogType.Info, "ActionsViewModel created");

        public ActionsViewModel()
        {
            Actions = new ObservableCollection<SingleActionViewModel>
            {
                new SingleActionViewModel(
                    "Action 1",
                    "This is action 1",
                    new RelayCommand<string>(ReadSN),
                    new RelayCommand<string>(WriteSN)
                ),
                new SingleActionViewModel(
                    "Action 2",
                    "This is action 2",
                    new RelayCommand<string>(ReadIMEI),
                    new RelayCommand<string>(WriteIMEI)
                ),
            };
        }

        private void ReadSN(string? obj)
        {
            //var action = Actions.FirstOrDefault(a => a.Text == text);
            //if (action != null)
            //{
            //    action.Text = "Read SN";
            //}

            LogMessage(LogType.Warning, "ReadSN");
        }

        private void WriteSN(string? text)
        {
            // 修改Text属性
            var action = Actions.FirstOrDefault(a => a.Text == text);
            if (action != null)
            {
                action.Text = "Write SN";
            }

            LogMessage(LogType.Warning, "WriteSN");
        }

        private void ReadIMEI(string? text)
        {
            var action = Actions.FirstOrDefault(x => x.Text == text);
            if (action != null)
            {
                action.Text = "Read IMEI";
            }
            LogMessage(LogType.Warning, "ReadIMEI");
        }

        private void WriteIMEI(string? text)
        {
            var action = Actions.FirstOrDefault(x => x.Text == text);
            if (action != null)
            {
                action.Text = "Write IMEI";
            }
            LogMessage(LogType.Error, "WriteIMEI");
        }

        private void LogMessage(LogType type, string message)
        {
            var log = new Log(type, message);
            WeakReferenceMessenger.Default.Send(new ValueChangedMessage<Log>(log));
        }
    }
}
