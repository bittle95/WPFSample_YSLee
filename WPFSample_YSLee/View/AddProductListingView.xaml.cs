﻿using System;
using System.Collections.Generic;
using System.IO;
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
using WPFSample_YSLee.Model;

namespace WPFSample_YSLee
{
    /// <summary>
    /// AddProductListingView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class AddProductListingView : Window
    {
        int thick = 3;
        int thin = 1;
        public AddProductListingView()
        {
            InitializeComponent();
            this.DataContext = new Model.ViewModel();
        }

        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)ColorComboBox.SelectedItem;

            //현재 콘텍스트를 가져옴
            Model.ViewModel viewModel = this.DataContext as Model.ViewModel;

            if (selectedItem != null)
            {
                string selectedValue = selectedItem.Content.ToString();

                switch (selectedValue)
                {
                    case "None":
                        viewModel.BorderColor = Brushes.Black;
                        viewModel.Thickness = new Thickness(thin);
                        viewModel.ImagePath = "";
                        break;
                    case "Color":
                        viewModel.BorderColor = Brushes.LightSkyBlue;
                        viewModel.Thickness = new Thickness(thick);
                        viewModel.ImagePath = "";
                        break;
                    case "Highlight":
                        viewModel.BorderColor = Brushes.Orange;
                        viewModel.Thickness = new Thickness(thick);
                        var basePath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                        var imagePath = Path.Combine(basePath, "Resource", "Star.png");
                        viewModel.ImagePath = imagePath;
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
                Products newProduct = new Products(viewModel);

                // MainView의 ViewModel에 상품 추가
                viewModel.AddProduct(newProduct);

                // 창 닫기 전에 데이터 초기화
                viewModel.SetInitialProductValue();

                // 현재 창 닫기
                this.Close();
            }
        }
    }
}