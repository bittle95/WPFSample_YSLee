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
            this.DataContext = new Model.ViewModel();
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

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            // 현재 창의 데이터 컨텍스트를 가져옴
            Model.ViewModel viewModel = this.DataContext as Model.ViewModel;

            if (viewModel != null)
            {
                // 새로운 상품 생성
                Products newProduct = new Products
                {
                    Discription = viewModel.Discription,
                    StartPrice = viewModel.StartPrice,
                    StartDate = viewModel.StartDate,
                    Category = viewModel.Category,
                    Special_Feature = viewModel.Special_Feature
                };

                // MainView의 ViewModel에 상품 추가
                viewModel.AddProduct(newProduct);

                // 현재 창 닫기
                this.Close();
            }
        }
    }
}