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
    /// Interaction logic for DeliFood.xaml
    /// </summary>
    public partial class DeliFood : Window
    {
        SupermarketContainer db = new SupermarketContainer();
        public DeliFood()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Shows deli food table items in Datagrid
            var query = from c in db.DeliFoods
                        select c;

            DgDeliFood.ItemsSource = query.ToList();
        }

        private void btnEveryDayItems_Click(object sender, RoutedEventArgs e)
        {
            //Brings me to EverydayItems windows
            EverydayItems everydayItems = new EverydayItems();
            everydayItems.ToString();
            this.Close();
        }

        private void btnOffLisence_Click(object sender, RoutedEventArgs e)
        {
            //When clicked shows Off Licsence window
            OffLicense offLicense = new OffLicense();
            offLicense.ToString();
            this.Close();
        }

        private void btnScan_Click(object sender, RoutedEventArgs e)
        {
            //When Clicked will Scan the selected item
            var transferItem = DgDeliFood.SelectedItem.ToString();
            DgDeliFoodBasket.Items.Add(transferItem);
        }

        private void btnRefund_Click(object sender, RoutedEventArgs e)
        {
            //When Clicked will Refund the selected item
            var transferItem = DgDeliFoodBasket.SelectedItem.ToString();
            DgDeliFood.Items.Add(transferItem);
        }
    }
}
