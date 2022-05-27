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

namespace Forum
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void LogInBtn_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTBox.Text == "" || PasswordPBox.Password == "")
            {
                MessageBox.Show("Введите логин и пароль");
            }
            else
            {
                User user = Context.db.Users.FirstOrDefault(q => q.Login == LoginTBox.Text && q.Password == PasswordPBox.Password);
                if (user != null)
                {
                    Context.userSession = user;
                    Context.db.SaveChanges();

                   
                    new Menu().Show();
                   
                    this.Close();                                                                                                         
                }
                else
                {
                    MessageBox.Show("Неправильные логин или пароль");
                }
            }
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            new Registration().Show();
            this.Close();
        }
    }
}
