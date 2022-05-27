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
using System.Windows.Shapes;

namespace Forum
{
    /// <summary>
    /// Логика взаимодействия для TaskWindow.xaml
    /// </summary>
    public partial class TaskWindow : Window
    {
        public TaskWindow(Task selectedTask)
        {
            InitializeComponent();
            LoadData(selectedTask);
            Task currentTask = selectedTask;
            DataContext = currentTask;
        }

        private void LoadData(Task selectedTask)
        {
            
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            new Menu().Show();
            this.Close();
        }

        private void AcceptBtn_Click(object sender, RoutedEventArgs e)
        {
            Task currentTask = Context.task;
            DataContext = currentTask;
            currentTask.Status = 2;
            currentTask.IdWorker = Context.userSession.Id;
            Context.db.SaveChanges();
            MessageBox.Show("Вы приняли задание");
            new Menu().Show();
            this.Close();
        }
    }
}
