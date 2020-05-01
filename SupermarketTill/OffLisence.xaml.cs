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

namespace SupermarketTill
{
    /// <summary>
    /// Interaction logic for OffLisence.xaml
    /// </summary>
    public partial class OffLisence : Window
    {
        SupermarketContainer db = new SupermarketContainer();
        public OffLisence()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            var query = from b in db.OffLicenses
                       select b;

            DgOffLisence.ItemsSource = query.ToList();


        }

        

        private void btnDeliFood2_Click(object sender, RoutedEventArgs e)
        {
            DeliFood deliFood = new DeliFood();
            deliFood.Show();
            this.Close();
        }

        private void btnEveryDayItems_Click(object sender, RoutedEventArgs e)
        {
            EverydayItems everydayItems = new EverydayItems();
            everydayItems.ToString();
            this.Close();
        }

        private void btnRefund_Click(object sender, RoutedEventArgs e)
        {
            //When Clicked will Refund the selected item
            var transferItem = DgOffLisenceBasket.SelectedItem.ToString();
            DgOffLisence.Items.Add(transferItem);
        }

        private void btnScan_Click(object sender, RoutedEventArgs e)
        {
            // When Clicked will Scan the selected item
            var transferItem = DgOffLisence.SelectedItem.ToString();
            DgOffLisenceBasket.Items.Add(transferItem);
        }

        
    }
}
