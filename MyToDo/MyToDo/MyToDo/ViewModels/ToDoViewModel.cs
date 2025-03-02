using MyToDo.Common.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDo.ViewModels
{
    class ToDoViewModel : BindableBase
    {

        public ToDoViewModel()
        {
            ToDoDtos = new ObservableCollection<ToDoDto>();
            CreateTestData();
        }
        private ObservableCollection<ToDoDto>? toDoDtos;

        public ObservableCollection<ToDoDto>? ToDoDtos
        {
            get { return toDoDtos; }
            set { toDoDtos = value; RaisePropertyChanged(); }
        }

        private bool isRightDrawerOpen;

        public bool IsRightDrawerOpen
        {
            get { return isRightDrawerOpen; }
            set { isRightDrawerOpen = value; RaisePropertyChanged(); }
        }

        public DelegateCommand AddCommand => new DelegateCommand(() =>
        {
            IsRightDrawerOpen = true;
            ToDoDtos?.Add(new ToDoDto { Content = "测试", Title = "测试" });
        });

        void CreateTestData()
        {
            ToDoDtos = new ObservableCollection<ToDoDto>();
            for (int i = 0; i < 10; i++)
            {
                ToDoDtos.Add(new ToDoDto { Content = "测试" + i, Title = "测试" + i });
            }
        }
    }
}
