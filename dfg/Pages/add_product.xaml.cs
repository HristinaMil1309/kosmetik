using dfg.Classes;
using dfg.Folder_BD;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace dfg.Pages
{
    /// <summary>
    /// Логика взаимодействия для add_product.xaml
    /// </summary>
    public partial class add_product : Page
    {
        public add_product()
        {
            InitializeComponent();

            ed_izmerenia_product.ItemsSource = BD_Class.BD.Ed_izmerenia.ToList();
            category_product.ItemsSource = BD_Class.BD.Category.ToList();
            supplier_product.ItemsSource = BD_Class.BD.Supplier.ToList();
            manufacturer_product.ItemsSource = BD_Class.BD.Manufacturer.ToList();
        }

        private void ADD_product_Click(object sender, RoutedEventArgs e)
        {
            Folder_BD.Products produ = new Folder_BD.Products()
            {
                article_number = article_number_product.Text,
                title = title_product.Text,
                count_of_stok = int.Parse(count_of_stok_product.Text),
                description = description_product.Text,
                price = int.Parse(price_product.Text),
                discount = int.Parse(discount_product.Text),
                id_ed_izmerenia = ((Ed_izmerenia)ed_izmerenia_product.SelectedItem).id,
                id_category = ((Category)category_product.SelectedItem).id,
                id_supplier = ((Supplier)supplier_product.SelectedItem).id,
                id_manufacturer = ((Manufacturer)manufacturer_product.SelectedItem).id
                
            };
            BD_Class.BD.Products.Add(produ);
            BD_Class.BD.SaveChanges();
        }

        private void add_image_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
