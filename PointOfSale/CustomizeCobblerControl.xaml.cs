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
using ExamTwoCodeQuestions.Data;

namespace ExamTwoQuestions.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCobblerControl.xaml
    /// </summary>
    public partial class CustomizeCobblerControl : UserControl
    {
        public CustomizeCobblerControl()
        {
            InitializeComponent();
        }

        private void Flavor_Checked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Cobbler cobbler)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "Peach":
                            cobbler.Fruit = FruitFilling.Peach;
                            Peach.Background = Brushes.LightGreen;
                            Cherry.Background = Brushes.White;
                            Blueberry.Background = Brushes.White;
                            break;
                        case "Blueberry":
                            cobbler.Fruit = FruitFilling.Blueberry;
                            Peach.Background = Brushes.White;
                            Cherry.Background = Brushes.White;
                            Blueberry.Background = Brushes.LightGreen;
                            break;
                        case "Cherry":
                            cobbler.Fruit = FruitFilling.Cherry;
                            Peach.Background = Brushes.White;
                            Cherry.Background = Brushes.LightGreen;
                            Blueberry.Background = Brushes.White;
                            break;
                    }
                }
            }
        }
    }
}
