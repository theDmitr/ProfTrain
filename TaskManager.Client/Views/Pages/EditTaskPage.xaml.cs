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

namespace TaskManager.Client.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditTaskPage.xaml
    /// </summary>
    public partial class EditTaskPage : Page
    {
        public EditTaskPage()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as TasksViewModel).SaveCurrentEditTask();
            TasksPage.CurrentFrame = null;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить данную задачу?", "Подтвердите действие", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
                return;

            (DataContext as TasksViewModel).DeleteCurrentEditTask();
            TasksPage.CurrentFrame = null;
        }
    }
}
