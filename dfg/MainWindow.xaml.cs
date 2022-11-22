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

namespace dfg
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Frame menu_admin;

        public MainWindow()
        {
            InitializeComponent();
            Classes.frame_class.FRAGG = fRAME_MAIN;
            Classes.frame_class.FRAGG.Navigate(new Pages.autoriz());
            Classes.BD_Class.BD = new Folder_BD.baza_mod();
            Classes.Menu_Frame_Class.menuFrame = menu_admin;
        }
    }
}
