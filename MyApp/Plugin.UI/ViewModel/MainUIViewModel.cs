using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Plugin.UI.View;

namespace Plugin.UI.ViewModel
{
    partial class MainUIViewModel : ObservableObject
    {
        [ObservableProperty]
        private UserControl? selectedView;

        public MainUIViewModel()
        {
            NavigateCommand = new RelayCommand<string?>(Navigate);
        }

        public RelayCommand<string?> NavigateCommand { get; }

        private void Navigate(string? viewName)
        {
            switch (viewName)
            {
                case "Action1":
                    //SelectedView = new ActionsView();
                    break;
                case "Action2":
                    // 这里可以添加其他视图
                    break;
                default:
                    //SelectedView = null;
                    break;
            }
        }
    }
}
