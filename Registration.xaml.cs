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
    public partial class Registration : Window
    {
        private List<User> Users = new List<User>();      
        public Registration()
        {
            InitializeComponent();       
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            if (LgnBox.Text != "" && PsBox.Text != "" && NameBox.Text != "" && SecNameBox.Text != "" && LastNameBox.Text != "" && PhoneBox.Text != "")
            {
                User user = new User()
                {
                    Login = LgnBox.Text,
                    Password = PsBox.Text,
                    FirstName = LgnBox.Text,
                    SecondName = SecNameBox.Text,
                    LastName = LastNameBox.Text,
                    Phone = PhoneBox.Text
                    
                };
                Context.userSession = user;
                Context.db.Users.Add(user);
                Context.db.SaveChanges();

                

                MessageBox.Show("Вы успешно зарегестрировались!");
                new Menu().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }
    }
}
