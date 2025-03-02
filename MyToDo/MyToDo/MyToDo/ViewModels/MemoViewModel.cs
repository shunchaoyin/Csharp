using MyToDo.Common.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDo.ViewModels
{
    class MemoViewModel : BindableBase
    {

        public MemoViewModel()
        {
            MemoDtos = new ObservableCollection<MemoDto>();
            CreateTestData();
        }
        private ObservableCollection<MemoDto>? memoDtos;

        public ObservableCollection<MemoDto>? MemoDtos
        {
            get { return memoDtos; }
            set { memoDtos = value; RaisePropertyChanged(); }
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
            MemoDtos?.Add(new MemoDto { Content = "测试", Title = "测试" });
        });

        void CreateTestData()
        {
            MemoDtos = new ObservableCollection<MemoDto>();
            for (int i = 0; i < 10; i++)
            {
                MemoDtos.Add(new MemoDto { Content = "测试" + i, Title = "测试" + i });
            }
        }
    }
}
