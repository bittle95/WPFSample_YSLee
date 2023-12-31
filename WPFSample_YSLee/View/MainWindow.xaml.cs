﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using WPFSample_YSLee.Model;
using static WPFSample_YSLee.Model.Products;

namespace WPFSample_YSLee
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new ViewModel();
        }

        private void NavigateToNewPage(object sender, RoutedEventArgs e)
        {
            if (Application.Current.Windows.OfType<AddProductListingView>().Any())
            {
                return; //여러 창이 Open 되는 것을 방지
            }
            AddProductListingView addProductListView = new AddProductListingView();
            addProductListView.DataContext = this.DataContext; //addProductList View로 콘텍스트 전달
            addProductListView.Show();
        }

        // 선택된 List 아이템의 속성 값들을 MainView의 TextBlock들에 할당 기능
        private void lstNamesSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstNames.SelectedItem != null)
            {
                Products selectedProduct = (Products)lstNames.SelectedItem;
                txtDescription.Text = selectedProduct.Discription;
                txtStartPrice.Text = selectedProduct.StartPrice.ToString();
                txtStartDate.Text = selectedProduct.StartDate;
                txtCategory.Text = selectedProduct.Category;
                txtOwnersName.Text = selectedProduct.OwnersName;
                txtOwnerRating.Text = selectedProduct.OwnersRating.ToString();
                txtMemberSince.Text = selectedProduct.MemberSince;

                lstAuction.ItemsSource = new List<AuctionPerson>()
                {
                    new AuctionPerson { AucName = "James", AucPrice = 200.ToString() },
                    new AuctionPerson { AucName = "John", AucPrice = 201.ToString() }
                };
            }
        }
        ICollectionView collectionView = null;

        private void GroupByCategory(object sender, RoutedEventArgs e)
        {
            ViewModel viewModel = (ViewModel)this.DataContext;

            if(GroupByCategoryCheckbox.IsChecked == true)
            {
                collectionView = CollectionViewSource.GetDefaultView(viewModel.ProductList);
                collectionView.GroupDescriptions.Add(new PropertyGroupDescription("Category"));
            }
            else
            {
                collectionView = CollectionViewSource.GetDefaultView(viewModel.ProductList);
                collectionView.GroupDescriptions.Clear();
            }
            // ListBox에 ICollectionView를 바인딩
            lstNames.ItemsSource = collectionView;
        }

        private void ShowBargain(object sender, RoutedEventArgs e)
        {
            ViewModel viewModel = (ViewModel)this.DataContext;
            collectionView = CollectionViewSource.GetDefaultView(viewModel.ProductList);
            if(collectionView== null)
            {
                return;
            }
            if (ShowBargainCheckBox.IsChecked == true)
            {
                collectionView.Filter = item =>
                {
                    Products product = item as Products;
                    return product != null && product.IsBargain;
                };
            }

            else
            {
                collectionView.Filter = null;
            }
        }
        private void SortByCategoryandDate(object sender, RoutedEventArgs e)
        {
            ViewModel viewModel = (ViewModel)this.DataContext;
            collectionView = CollectionViewSource.GetDefaultView(viewModel.ProductList);
            if (collectionView == null)
            {
                return;
            }
            if (SortByCategoryandDateCheckbox.IsChecked == true)
            {
                collectionView.SortDescriptions.Clear();
                collectionView.SortDescriptions.Add(new SortDescription("Category", ListSortDirection.Ascending));
                collectionView.SortDescriptions.Add(new SortDescription("StartDate", ListSortDirection.Ascending));
            }
            else
            {
                collectionView.SortDescriptions.Clear();
            }
        }
    }
}
