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
using System.Windows.Navigation;
using System.Windows.Shapes;

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
        }

        private void NavigateToNewPage_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.Windows.OfType<AddProductListingView>().Any())
            {
                return; //여러 창이 Open 되는 것을 방지
            }
            AddProductListingView addProductListView = new AddProductListingView();
            addProductListView.Show();
        }
    }
}
