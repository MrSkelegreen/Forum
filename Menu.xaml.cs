using Microsoft.EntityFrameworkCore;
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
    public partial class Menu : Window
    {
        
        public Menu()
        {      
            InitializeComponent();
            LoadData();
            TaskGrid.SelectedItem = null;           
            User currentUser = new User();
            currentUser = Context.userSession;
            DataContext = currentUser;          
        }
        private void LoadData()
        {
            TaskGrid.ItemsSource = Context.db.Tasks.Where(t => t.Status == 1).Include(u => u.IdAuthorNavigation).ToList();                     
        }
        private void List_Click(object sender, RoutedEventArgs e)
        {
            new UserList().Show();
            this.Close();
        }

        private void ProfileBtn_Click(object sender, RoutedEventArgs e)
        {
            new Profile().Show();
            this.Close();
        }

        private void TaskGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Task selectedTask = TaskGrid.SelectedItem as Task;                      
        }
        private void TaskGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Task selectedTask = TaskGrid.SelectedItem as Task;
            Context.task = selectedTask;
            new TaskWindow(selectedTask).Show();
            this.Close();
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            var user = Context.db.Users.FirstOrDefault(q => q.Login == LoginBox.Text);
            if(user != null)
            {
                Task task = Context.db.Tasks.FirstOrDefault(t => t.IdAuthor == user.Id);
                new TaskWindow(task).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }
        }
    }
}