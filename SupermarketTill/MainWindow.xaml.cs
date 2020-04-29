﻿using System;
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

namespace SupermarketTill
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SupermarketContainer db = new SupermarketContainer();

        public MainWindow()
        {
            InitializeComponent(); 
        }

        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from a in db.EverydayItems
                        select a.Name;

            DgEveryDayItems.ItemsSource = query.ToList();

            {
                var transferItem = DgEveryDayItems.SelectedItem.ToString();
                dgEverydayItemsBasket.Items.Add(transferItem);                
            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }




        /* private void btnAdd_Click(object sender, RoutedEventArgs e)
         {
             EveryDayItems selectedEveryDayItems = DgEveryDayItems.SelectedItem as EveryDayItems;
         }*/













    }
}
