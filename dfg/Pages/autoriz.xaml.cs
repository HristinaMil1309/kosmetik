using dfg.Classes;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace dfg.Pages
{
    /// <summary>
    /// Логика взаимодействия для autoriz.xaml
    /// </summary>
    public partial class autoriz : Page
    {
        public autoriz()
        {
            InitializeComponent();
        }


        private void vhod_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var perem_dla_bd = BD_Class.BD.Users.Where(x => x.login == LOGIN_AUTO.Text && x.password == PASSWORD_AUTO.Text).FirstOrDefault();

                if (perem_dla_bd == null)
                {
                    MessageBox.Show("Нема", "Вы дэбил", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBoxResult boxResult = MessageBox.Show("Добро пожаловать " + perem_dla_bd.Roles.name_role + " " + perem_dla_bd.F_I_O, "Уведомляю");
                    if (boxResult == MessageBoxResult.OK)
                    {
                        BD_Class.user = perem_dla_bd;
                        switch (perem_dla_bd.id_Roles)
                        {
                            case 1:
                                frame_class.FRAGG.Navigate(new admin());
                                break;
                            case 2:
                                frame_class.FRAGG.Navigate(new manager());
                                break;
                            case 3:
                                frame_class.FRAGG.Navigate(new klient());
                                break;

                        }
                    }

                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("ошибка" + EX.Message.ToString() + "HER", "HER", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            Classes.frame_class.FRAGG.Navigate(new Pages.registrr());
        }
    }
}
