using System;
using System.Data;
using System.Windows;

namespace TaskManagerDesktop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            CurrentDateText.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");

            UpdateStatusBar(0, 0);

            StatusText.Text = "Приложение загружено. Готово к работе.";
        }

        private void UpdateStatusBar(int totalTasks, int completedTasks)
        {
            TasksCountText.Text = totalTasks.ToString();
            CompletedCountText.Text = completedTasks.ToString();
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown ();
        }
    }
}