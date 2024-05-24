using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TaskManager.Client.Views.Pages;
using TaskManager.Common.Dtos;

namespace TaskManager.Client.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static Frame Frame;
        public static Page CurrentPage {  set => Frame.Content = value; }

        public MainWindow()
        {
            InitializeComponent();
            Frame = MainFrame;
            CurrentPage = new MenuPage();
        }
    }
}
