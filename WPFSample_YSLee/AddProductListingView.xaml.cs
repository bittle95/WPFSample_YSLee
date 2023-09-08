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
using WPFSample_YSLee.Model;

namespace WPFSample_YSLee
{
    /// <summary>
    /// AddProductListingView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class AddProductListingView : Window
    {
        public AddProductListingView()
        {
            InitializeComponent();
            this.DataContext = new ViewModel_Test();
        }

        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)ColorComboBox.SelectedItem;

            if (selectedItem != null)
            {
                string selectedValue = selectedItem.Content.ToString();

                switch (selectedValue)
                {
                    case "None":
                        TargetBorderName.BorderBrush = Brushes.Black;
                        TargetBorderName.BorderThickness = new Thickness(1);
                        break;
                    case "Color":
                        TargetBorderName.BorderBrush = Brushes.LightSkyBlue;
                        TargetBorderName.BorderThickness = new Thickness(3);
                        break;
                    case "Highlight":
                        TargetBorderName.BorderBrush = Brushes.Orange;
                        TargetBorderName.BorderThickness = new Thickness(3);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
