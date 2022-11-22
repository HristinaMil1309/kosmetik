using dfg.Classes;
using System.Windows;
using System.Windows.Controls;

namespace dfg.Pages
{
    /// <summary>
    /// Логика взаимодействия для admin.xaml
    /// </summary>
    public partial class admin : Page
    {
        public admin()
        {
            InitializeComponent();
            Menu_Frame_Class.menuFrame = menu_admin;
            Menu_Frame_Class.menuFrame.Navigate(new glav_admin());
            user_n.Text = BD_Class.user.Roles.name_role + " " + BD_Class.user.F_I_O;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Menu_Frame_Class.menuFrame.Navigate(new profile_admin());
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Menu_Frame_Class.menuFrame.Navigate(new product());
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Menu_Frame_Class.menuFrame.Navigate(new add_product());
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Menu_Frame_Class.menuFrame.Navigate(new users_admin());
        }
    }
}
