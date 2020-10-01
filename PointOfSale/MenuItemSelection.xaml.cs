using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using PointOfSale.Drinks;
using PointOfSale.Sides;
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

        /// <summary>
        /// sets new BriarheartBurger object as DataContext of the customization screen
        /// binds form controls to object properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CustomizeItem (object sender, RoutedEventArgs e)
        {
            BriarheartBurger b = new BriarheartBurger();
            var customizeScreen = new MenuItemCustomization();
            //set DataContext
            customizeScreen.DataContext = b;
            //databinding
            customizeScreen.bunCheckBox.IsChecked = b.Bun;
            customizeScreen.ketchupCheckBox.IsChecked = b.Ketchup;
            customizeScreen.mustardCheckBox.IsChecked = b.Mustard;
            customizeScreen.pickleCheckBox.IsChecked = b.Pickle;
            customizeScreen.cheeseCheckBox.IsChecked = b.Cheese;
            //switch screen
            selectionBorder.Child = customizeScreen;    
        }

        /// <summary>
        /// sets new object as DataContext of the customization screen
        /// binds form controls to object properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoubleDraugrCustomization(object sender, RoutedEventArgs e)
        {
            DoubleDraugr d = new DoubleDraugr();
            var customizeScreen = new DraugrDoubleCustomization();
            //set DataContext
            customizeScreen.DataContext = d;
            //databinding
            customizeScreen.bunCheckBox.IsChecked = d.Bun;
            customizeScreen.ketchupCheckBox.IsChecked = d.Ketchup;
            customizeScreen.mustardCheckBox.IsChecked = d.Mustard;
            customizeScreen.pickleCheckBox.IsChecked = d.Pickle;
            customizeScreen.cheeseCheckBox.IsChecked = d.Cheese;
            customizeScreen.tomatoCheckBox.IsChecked = d.Tomato;
            customizeScreen.lettuceCheckBox.IsChecked = d.Lettuce;
            //switch screen
            selectionBorder.Child = customizeScreen;
        }

        /// <summary>
        /// sets new object as DataContext of the customization screen
        /// binds form controls to object properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CustomizeThalmorTriple(object sender, RoutedEventArgs e)
        {
            ThalmorTriple t = new ThalmorTriple();
            var customizeScreen = new CustomizeThalmorTriple();
            //set DataContext
            customizeScreen.DataContext = t;
            //databinding
            customizeScreen.bunCheckBox.IsChecked = t.Bun;
            customizeScreen.ketchupCheckBox.IsChecked = t.Ketchup;
            customizeScreen.mustardCheckBox.IsChecked = t.Mustard;
            customizeScreen.pickleCheckBox.IsChecked = t.Pickle;
            customizeScreen.cheeseCheckBox.IsChecked = t.Cheese;
            customizeScreen.tomatoCheckBox.IsChecked = t.Tomato;
            customizeScreen.lettuceCheckBox.IsChecked = t.Lettuce;
            customizeScreen.eggCheckBox.IsChecked = t.Egg;
            customizeScreen.baconCheckBox.IsChecked = t.Bacon;
            //switch screen
            selectionBorder.Child = customizeScreen;
        }

        /// <summary>
        /// sets new object as DataContext of the customization screen
        /// binds form controls to object properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CustomizeSmokehouseSkeleton(object sender, RoutedEventArgs e)
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            var customizeScreen = new CustomizeSmokehouseSkeleton();
            //set DataContext
            customizeScreen.DataContext = s;
            //databinding
            customizeScreen.sausageCheckBox.IsChecked = s.SausageLink;
            customizeScreen.eggCheckBox.IsChecked = s.Egg;
            customizeScreen.hashbrownsCheckBox.IsChecked = s.HashBrowns;
            customizeScreen.pancakeCheckBox.IsChecked = s.Pancake;
            //switch screen
            selectionBorder.Child = customizeScreen;
        }

        /// <summary>
        /// no customization options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CustomizeThugsTBone(object sender, RoutedEventArgs e)
        {
            var customize = new CustomizeThugsTBone();
            selectionBorder.Child = customize;
        }

        /// <summary>
        /// sets new object as DataContext of the customization screen
        /// binds form controls to object properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CustomizePhillyPoacher(object sender, RoutedEventArgs e)
        {
            PhillyPoacher p = new PhillyPoacher();
            var customizeScreen = new CustomizePhillyPoacher();
            //set DataContext
            customizeScreen.DataContext = p;
            //databinding
            customizeScreen.sirloinCheckBox.IsChecked = p.Sirloin;
            customizeScreen.onionCheckBox.IsChecked = p.Onion;
            customizeScreen.rollCheckBox.IsChecked = p.Roll;
            //switch screen
            selectionBorder.Child = customizeScreen;
        }

        /// <summary>
        /// sets new object as DataContext of the customization screen
        /// binds form controls to object properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CustomizeGardenOrcOmelette(object sender, RoutedEventArgs e)
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            var customizeScreen = new CustomizeGardenOrcOmelette();
            //set DataContext
            customizeScreen.DataContext = g;
            //databinding
            customizeScreen.broccoliCheckBox.IsChecked = g.Broccoli;
            customizeScreen.mushroomCheckBox.IsChecked = g.Mushrooms;
            customizeScreen.tomatoCheckBox.IsChecked = g.Tomato;
            customizeScreen.cheddarCheckBox.IsChecked = g.Cheddar;
            //switch screen
            selectionBorder.Child = customizeScreen;
        }

        /// <summary>
        /// sets new DragonbornWaffleFries object as DataContext of the customization screen
        /// binds form controls to object properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CustomizeSize(object sender, RoutedEventArgs e)
        {
            DragonbornWaffleFries d = new DragonbornWaffleFries();
            var customizeScreen = new CustomizeSide();
            //set DataContext
            customizeScreen.DataContext = d;
            //databinding
            //size

            //switch screen
            selectionBorder.Child = customizeScreen;
            
        }

        /// <summary>
        /// sets new object as DataContext of the customization screen
        /// binds form controls to object properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CustomizeMadOtarGrits(object sender, RoutedEventArgs e)
        {
            MadOtarGrits g = new MadOtarGrits();
            var customizeScreen = new CustomizeMadOtarGrits();
            //set DataContext
            customizeScreen.DataContext = g;
            //databinding
            //size

            //customizeScreen.smallSizeButton;
            //customizeScreen.mediumSizeButton;
            //customizeScreen.largeSizeButton;
            
            //switch screen
            selectionBorder.Child = customizeScreen;
        }

        /// <summary>
        /// sets new object as DataContext of the customization screen
        /// binds form controls to object properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CustomizeFriedMiraak(object sender, RoutedEventArgs e)
        {
            FriedMiraak m = new FriedMiraak();
            var customizeScreen = new CustomizeFriedMiraak();
            //set DataContext
            customizeScreen.DataContext = m;
            //databinding
            //size

            //switch screen
            selectionBorder.Child = customizeScreen;
        }

        /// <summary>
        /// sets new object as DataContext of the customization screen
        /// binds form controls to object properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CustomizeVokunSalad(object sender, RoutedEventArgs e)
        {
            VokunSalad v = new VokunSalad();
            var customizeScreen = new CustomizeVokunSalad();
            //set DataContext
            customizeScreen.DataContext = v;
            //databinding
            //size

            //switch screen
            selectionBorder.Child = customizeScreen;
        }

        /// <summary>
        /// sets new object as DataContext of the customization screen
        /// binds form controls to object properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CustomizeWarriorWater(object sender, RoutedEventArgs e)
        {
            WarriorWater w = new WarriorWater();
            var customizeScreen = new CustomizeWarriorWater();
            //set DataContext
            customizeScreen.DataContext = w;
            //databinding
            customizeScreen.iceCheckBox.IsChecked = w.Ice;
            customizeScreen.lemonCheckBox.IsChecked = w.Lemon;
            //size

            //switch screen
            selectionBorder.Child = customizeScreen;
        }

        /// <summary>
        /// sets new object as DataContext of the customization screen
        /// binds form controls to object properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CustomizeMarkarthMilk(object sender, RoutedEventArgs e)
        {
            MarkarthMilk m = new MarkarthMilk();
            var customizeScreen = new CustomizeMarkarthMilk();
            //set DataContext
            customizeScreen.DataContext = m;
            //databinding
            customizeScreen.iceCheckBox.IsChecked = m.Ice;
            //size

            //switch screen
            selectionBorder.Child = customizeScreen;
        }

        /// <summary>
        /// sets new AretinoAppleJuice object as DataContext of the customization screen
        /// binds form controls to object properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CustomizeIce(object sender, RoutedEventArgs e)
        {
            AretinoAppleJuice j = new AretinoAppleJuice();
            var customizeScreen = new CustomizeIce();
            //set DataContext
            customizeScreen.DataContext = j;
            //databinding
            customizeScreen.iceCheckBox.IsChecked = j.Ice;
            //size

            //switch screen
            selectionBorder.Child = customizeScreen;
        }

        /// <summary>
        /// sets new object as DataContext of the customization screen
        /// binds form controls to object properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CustomizeSailorSoda(object sender, RoutedEventArgs e)
        {
            SailorSoda s = new SailorSoda();
            var customizeScreen = new CustomizeSailorSoda();
            //set DataContext
            customizeScreen.DataContext = s;
            //databinding
            //size
            //flavor

            //switch screen
            selectionBorder.Child = customizeScreen;

        }

        /// <summary>
        /// sets new object as DataContext of the customization screen
        /// binds form controls to object properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CustomizeCandlehearthCoffee(object sender, RoutedEventArgs e)
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            var customizeScreen = new CustomizeCandlehearthCoffee();
            //set DataContext
            customizeScreen.DataContext = c;
            //databinding
            customizeScreen.iceCheckBox.IsChecked = c.Ice;
            customizeScreen.decafCheckBox.IsChecked = c.Decaf;
            customizeScreen.creamCheckBox.IsChecked = c.RoomForCream;
            //size

            //switch screen
            selectionBorder.Child = customizeScreen;
        }

    }
}
