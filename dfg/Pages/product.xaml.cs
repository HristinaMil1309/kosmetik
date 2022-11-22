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
using System.Windows.Threading;
using dfg.Classes;

namespace dfg.Pages
{
    /// <summary>
    /// Логика взаимодействия для product.xaml
    /// </summary>
    public partial class product : Page
    {
        public product()
        {
            InitializeComponent();
            List_product.ItemsSource = BD_Class.BD.Products.ToList();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += update;
            timer.Start();
        }
        private void update(object sender, EventArgs e)
        {
            BD_Class.BD = new Folder_BD.baza_mod();
            List_product.ItemsSource = BD_Class.BD.Products.ToList();
        }
        private void search_cmb_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        private void filtr_cmbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void sort_cmbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
