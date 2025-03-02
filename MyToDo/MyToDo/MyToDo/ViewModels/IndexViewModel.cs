using MyToDo.Common.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDo.ViewModels
{
    class IndexViewModel : BindableBase
    {
        public IndexViewModel()
        {
            TaskBars = new ObservableCollection<TaskBar>();
            CreateTaskBars();
            CreateTestData();
        }

        private ObservableCollection<TaskBar>? taskBars;

        public ObservableCollection<TaskBar>? TaskBars
        {
            get { return taskBars; }
            set { taskBars = value; RaisePropertyChanged(); }
        }

        private ObservableCollection<ToDoDto>? toDoDtos;

        public ObservableCollection<ToDoDto>? ToDoDtos
        {
            get { return toDoDtos; }
            set { toDoDtos = value; RaisePropertyChanged(); }
        }

        private ObservableCollection<MemoDto>? memoDtos;
        public ObservableCollection<MemoDto>? MemoDtos
        {
            get { return memoDtos; }
            set { memoDtos = value; RaisePropertyChanged(); }
        }

        void CreateTaskBars()
        {
            TaskBars = new ObservableCollection<TaskBar>
            {
                new TaskBar { Icon = "ClockFast", Title = "汇总", Color = "#FF0CA0FF", Target = "ToDoView" , Content = "9"},
                new TaskBar { Icon = "ClockCheckOutline", Title = "已完成", Color = "#FF1ECA3A", Target = "ToDoView",Content = "9" },
                new TaskBar {Icon = "ChartLineVariant", Title = "完成比例", Color = "#FF02C6DC", Target = "", Content = "9%" },
                new TaskBar { Icon = "PlaylistStar", Title = "备忘录", Color = "#FFFFA000", Target = "MemoView",Content = "9" }
            };
        }

        void CreateTestData() {
            ToDoDtos = new ObservableCollection<ToDoDto>
            {
                new ToDoDto { Title = "测试1", Content = "测试1" },
                new ToDoDto { Title = "测试2", Content = "测试2" },
                new ToDoDto { Title = "测试3", Content = "测试3" },
                new ToDoDto { Title = "测试4", Content = "测试4" },
                new ToDoDto { Title = "测试5", Content = "测试5" },
                new ToDoDto { Title = "测试6", Content = "测试6" },
                new ToDoDto { Title = "测试7", Content = "测试7" },
                new ToDoDto { Title = "测试8", Content = "测试8" },
                new ToDoDto { Title = "测试9", Content = "测试9" },
                new ToDoDto { Title = "测试10", Content = "测试0"}
            };
            MemoDtos = new ObservableCollection<MemoDto>
            {
                new MemoDto { Title = "备忘录1", Content = "备忘录1"},
                new MemoDto { Title = "备忘录2", Content = "备忘录2" },
                new MemoDto { Title = "备忘录3", Content = "备忘录3" },
                new MemoDto { Title = "备忘录4", Content = "备忘录4"},
                new MemoDto { Title = "备忘录5", Content = "备忘录5"},
                new MemoDto { Title = "备忘录6", Content = "备忘录6"}
            };

        }


    }
}
