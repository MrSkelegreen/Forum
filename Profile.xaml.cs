using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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
    /// Логика взаимодействия для Profile.xaml
    /// </summary>
    public partial class Profile : Window
    {
        public Profile()
        {
            InitializeComponent();          
            User currentUser = new User();
            currentUser = Context.userSession;
            DataContext = currentUser;
            LoadData(currentUser);
        }

        private void LoadData(User currentUser)
        {
            try
            {
                UserTasks.ItemsSource = Context.db.Tasks.Where(t => t.IdAuthor == currentUser.Id).Include(s => s.StatusNavigation).ToList();
            }
            catch
            {

            }
            
        }

        private void LoadChangedData()
        {
            UserTasks.ItemsSource = Context.db.Tasks.Where(t => t.IdAuthor == Context.userSession.Id).Include(s => s.StatusNavigation).ToList();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            new Menu().Show();
            this.Close();
        }
        private void UserTasks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Task selectedTask = UserTasks.SelectedItem as Task;

            if (selectedTask != null)
            {
                if (selectedTask.Status == 1)
                {
                    selectedTask.Status = 2;                    
                }
                else if (selectedTask.Status == 2)
                {
                    selectedTask.Status = 3;
                }
                else if (selectedTask.Status == 3)
                {
                    selectedTask.Status = 1;
                }
                Context.db.SaveChanges();
                LoadChangedData();
            }

            UserTasks.SelectedItem = null;
        }

        private void HistoryBtn_Click(object sender, RoutedEventArgs e)
        {
            new History().Show();
            this.Close();
        }
    }
}
