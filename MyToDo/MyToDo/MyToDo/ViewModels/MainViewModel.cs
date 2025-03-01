using MyToDo.Common.Models;
using MyToDo.Extensions;
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
        private readonly IRegionManager regionManager;

        public MainViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
            CreateMenuBars();
            MenuBarCommand = new DelegateCommand<MenuBar>(MenuBarExecute);

            GoBackCommand = new DelegateCommand(() =>
            {
                if (journal != null)
                {
                    journal.GoBack();
                }
            });

            GoForwardCommand = new DelegateCommand(() =>
            {
                if (journal != null)
                {
                    journal.GoForward();
                }
            });
        }

        private ObservableCollection<MenuBar>? menuBars;
        private IRegionNavigationJournal? journal;

        public ObservableCollection<MenuBar>? MenuBars
        {
            get { return menuBars; }
            set { menuBars = value; RaisePropertyChanged(); }
        }

        public DelegateCommand<MenuBar>? MenuBarCommand { get; set; }
        public DelegateCommand? GoBackCommand { get; private set; }
        public DelegateCommand? GoForwardCommand { get; private set; }


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

        private void MenuBarExecute(MenuBar menuBar)
        {
            if (menuBar == null)
            {
                throw new ArgumentNullException(nameof(menuBar));
            }

            regionManager.Regions[PrismManager.MainViewRegion].RequestNavigate(menuBar.NameSpace, back =>
            {
                if (back != null && back.Context != null && back.Context.NavigationService != null)
                {
                    journal = back.Context.NavigationService.Journal;
                }
            });
        }
    }
}
