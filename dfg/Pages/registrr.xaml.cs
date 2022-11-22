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
using System.Data.Entity;

namespace dfg.Pages
{
    /// <summary>
    /// Логика взаимодействия для registrr.xaml
    /// </summary>
    public partial class registrr : Page
    {
        public registrr()
        {
            InitializeComponent();
            Role_cbx.ItemsSource = Classes.BD_Class.BD.Roles.ToList();
        }

        private void creat_akka_Click(object sender, RoutedEventArgs e)
        {
            if (Classes.BD_Class.BD.Users.Count(x=> x.login == Login_reg.Text )>0)
            {
                MessageBox.Show("Вы дебил, такой пользователь уже есть ", "Ошибка регистрации ", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                Folder_BD.Users NEW_USERS = new Folder_BD.Users()
                {
                    F_I_O = Name.Text,
                    id_Roles = (Role_cbx.SelectedItem as Folder_BD.Roles).id,
                    login = Login_reg.Text,
                    password = Password_reg.Text

                };
                Classes.BD_Class.BD.Users.Add(NEW_USERS);
                Classes.BD_Class.BD.SaveChanges();
                MessageBox.Show("Данные успешно добавлены ", "Уведомлять нада ", MessageBoxButton.OK, MessageBoxImage.None);


            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message.ToString());
            }
        }
    }
}
