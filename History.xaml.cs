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
    /// Логика взаимодействия для History.xaml
    /// </summary>
    public partial class History : Window
    {
        public History()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            
            try
            {
                UserTasks.ItemsSource = Context.db.Tasks.Where(t => t.IdWorker == Context.userSession.Id && t.Status == 3).Include(s => s.StatusNavigation).ToList();
            }
            catch
            {

            }
        }
        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            new Profile().Show();
            this.Close();
        }
    }
}
