using System;
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
    /// Interaction logic for MenuItemSelection.xaml
    /// </summary>
    public partial class MenuItemSelection : UserControl
    {
        public MenuItemSelection()
        {
            InitializeComponent();
        }

        void CustomizeItem (object sender, RoutedEventArgs e)
        {
            var customize = new MenuItemCustomization();
            selectionBorder.Child = customize;    
        }

        void DoubleDraugrCustomization(object sender, RoutedEventArgs e)
        {
            var customize = new DraugrDoubleCustomization();
            selectionBorder.Child = customize;
        }

        void CustomizeThalmorTriple(object sender, RoutedEventArgs e)
        {
            var customize = new CustomizeThalmorTriple();
            selectionBorder.Child = customize;
        }

        void CustomizeSmokehouseSkeleton(object sender, RoutedEventArgs e)
        {
            var customize = new CustomizeSmokehouseSkeleton();
            selectionBorder.Child = customize;
        }

        void CustomizeThugsTBone(object sender, RoutedEventArgs e)
        {
            var customize = new CustomizeThugsTBone();
            selectionBorder.Child = customize;
        }

        void CustomizePhillyPoacher(object sender, RoutedEventArgs e)
        {
            var customize = new CustomizePhillyPoacher();
            selectionBorder.Child = customize;
        }

        void CustomizeGardenOrcOmelette(object sender, RoutedEventArgs e)
        {
            var customize = new CustomizeGardenOrcOmelette();
            selectionBorder.Child = customize;
        }

        void CustomizeSize(object sender, RoutedEventArgs e)
        {
            var customize = new CustomizeSide();
            selectionBorder.Child = customize;
        }

        void CustomizeIce(object sender, RoutedEventArgs e)
        {
            var customize = new CustomizeIce();
            selectionBorder.Child = customize;
        }
        void CustomizeSailorSoda(object sender, RoutedEventArgs e)
        {
            var customize = new CustomizeSailorSoda();
            selectionBorder.Child = customize;
        }

        void CustomizeCandlehearthCoffee(object sender, RoutedEventArgs e)
        {
            var customize = new CustomizeCandlehearthCoffee();
            selectionBorder.Child = customize;
        }

    }
}
