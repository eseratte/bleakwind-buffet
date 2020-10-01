using BleakwindBuffet.Data.Entrees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemCustomization.xaml
    /// </summary>
    public partial class MenuItemCustomization : UserControl
    {
        public MenuItemCustomization()
        {
            InitializeComponent();
        }      

        private void whenBriarheartBurgerPropertyChanges(object sender, PropertyChangedEventArgs e)
        {

        }

       void GoBackToItemSelect (object sender, RoutedEventArgs e)
        {
            var mainMenu = new MenuItemSelection();
            customizationBorder.Child = mainMenu;           
        }

        void CancelOrder(object sender, RoutedEventArgs e)
        {
            var mainMenu = new MenuItemSelection();
            customizationBorder.Child = mainMenu;
            //will empty order summary here once implemented

        }
    }
}
