using MyToDo.Common.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDo.ViewModels
{
    public class MainViewModel : BindableBase
    {
        public MainViewModel()
        {
            CreateMenuBars();
        }

        private ObservableCollection<MenuBar>? menuBars;

        public ObservableCollection<MenuBar>? MenuBars
        {
            get { return menuBars; }
            set { menuBars = value; RaisePropertyChanged(); }
        }

        void CreateMenuBars()
        {
            MenuBars = new ObservableCollection<MenuBar>
            {
                new MenuBar { Title = "首页", Icon = "home" ,NameSpace = "IndexView"},
                new MenuBar { Title = "代办事项", Icon = "NotebookEditOutline", NameSpace = "ToDoView" },
                new MenuBar { Title = "备忘录", Icon = "NotebookPlus" , NameSpace = "MemoView"},
                new MenuBar { Title = "设置", Icon = "Cog" ,NameSpace = "SettingsView"},
            };
        }
    }
}
