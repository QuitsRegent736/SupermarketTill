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
using System.Data.SqlClient;
using System.Collections.ObjectModel;

namespace SupermarketTill
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SupermarketContainer db = new SupermarketContainer();

        public EverydayItems Items { get; set; }


        public MainWindow()
        {
            InitializeComponent();

            //DataTemplate
            Item = new EverydayItems();
            Item.Name = Name;

            this.DataContext = this;
        }

        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            //Puts the items in in the EverdayItems Table into the datagrid
            var query = from a in db.EverydayItems
                        select a.Name;

            DgEveryDayItems.ItemsSource = query.ToList();

            


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //When Clicked will Scan the selected item
            var transferItem = DgEveryDayItems.SelectedItem.ToString();
            dgEverydayItemsBasket.Items.Add(transferItem);
        }

        private void btnDeliFood_Click(object sender, RoutedEventArgs e)
        {
            //When Clciked will bring me to deli window
            DeliFood deliFood = new DeliFood();
            deliFood.Show();
            this.Close();
        }

        private void btnRefund_Click(object sender, RoutedEventArgs e)
        {
            //When Clicked will Refund the selected item
            var transferItem = dgEverydayItemsBasket.SelectedItem.ToString();
            DgEveryDayItems.Items.Add(transferItem);
        }

        private void btnOffLisence_Click(object sender, RoutedEventArgs e)
        {
            //When clicked shows Off Licsence window
            OffLicense offLicense = new OffLicense();
            offLicense.ToString();
            this.Close();
        }

        //DataTemplate
        public EverydayItems Item { get; set; }
        


      public class MyDateTimeClass
        {
            public DateTime DT { get; set; } = DateTime.Now;
        }


        public ObservableCollection<EverydayItems> LstItem
        {
            get { return _LstEm; }
            set { SetProperty(ref _LstItem, value); }
        }
        


        /*<Window.DataContext>
        <Local:MyDatetimeclass/>
    </Window.DataContext>
    <Window.Resources>
        <Style TargetType = "TextBlock" >
            < Setter Property="FontSize" Value="14"
        </Style>
            

    </Window.Resources>

        <StackPanel>
                <TextBlock Text*/


    }
}
