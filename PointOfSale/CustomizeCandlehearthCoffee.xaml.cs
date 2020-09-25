﻿using System;
using System.Collections.Generic;
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
    /// Interaction logic for CustomizeCandlehearthCoffee.xaml
    /// </summary>
    public partial class CustomizeCandlehearthCoffee : UserControl
    {
        public CustomizeCandlehearthCoffee()
        {
            InitializeComponent();
        }
        void GoBackToItemSelect(object sender, RoutedEventArgs e)
        {
            var mainMenu = new MenuItemSelection();
            customizationBorder.Child = mainMenu;
        }

        void CancelOrder(object sender, RoutedEventArgs e)
        {
            var mainMenu = new MenuItemSelection();
            customizationBorder.Child = mainMenu;
        }
    }
}
