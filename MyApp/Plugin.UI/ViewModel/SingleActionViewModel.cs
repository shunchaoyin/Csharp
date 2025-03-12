using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Plugin.UI.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.UI.ViewModel
{
    partial class SingleActionViewModel:ObservableObject
    {
        [ObservableProperty]
        private string title;
        [ObservableProperty]
        private string text;

        public RelayCommand<string>? ReadCommand { get; set; }
        public RelayCommand<string>? WriteCommand { get; set; }

        public SingleActionViewModel(string title, string text, RelayCommand<string> readCommand, RelayCommand<string> writeCommand)
        {
            Title = title;
            Text = text;
            ReadCommand = readCommand;
            WriteCommand = writeCommand;
        }

    }
}
