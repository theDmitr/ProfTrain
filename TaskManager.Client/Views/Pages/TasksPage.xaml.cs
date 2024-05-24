using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TaskManager.Client.ViewModels;
using TaskManager.Common.Dtos;

namespace TaskManager.Client.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для TasksPage.xaml
    /// </summary>
    public partial class TasksPage : Page
    {
        private static Frame EditFrame;
        public static Page CurrentFrame { set => EditFrame.Content = value; }

        public TasksPage()
        {
            InitializeComponent();
            EditFrame = EditTaskFrame;
        }

        private void BorderTask_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var taskDto = (sender as Border).DataContext as TaskDto;
            TasksViewModel.staticCurrentEditTask = taskDto;
            CurrentFrame = new EditTaskPage();
        }
    }
}
