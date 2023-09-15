using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFSample_YSLee.Model
{
    //AddProductListingView 내에서만 바인딩하기 위한 뷰모델
    public class AddProductList_ViewModel : Notifier
    {
        string discription  = "Please enter a description";
        double startPrice   = 100;
        string startDate    = DateTime.Now.ToString("yyyy-MM-dd");
        string category     = "DVS's";
        string special_Features= "None";

        public string Discription
        {
            get { return discription; }
            set
            {
                discription = value;
                NotifyChanged("Discription");
            }
        }
        public string StartDate
        {
            get { return startDate; }
            set
            {
                startDate = value;
                NotifyChanged("StartDate");
            }
        }

        public double StartPrice
        {
            get { return startPrice; }
            set
            {
                if (Regex.IsMatch(value.ToString(), "^[0-9]*$"))
                {
                    startPrice = value;
                }
                else
                {
                    Console.WriteLine("True");
                }
                NotifyChanged("StartPrice");
            }
        }

        public string Category
        {
            get { return category; }
            set
            {
                category = value;
                NotifyChanged("Category");
            }
        }

        public string Special_Feature
        {
            get { return special_Features; }
            set
            {
                special_Features = value;
                NotifyChanged("Special_Feature");
            }
        }

        private ObservableCollection<Products> productList = new ObservableCollection<Products>();
        public ObservableCollection<Products> ProductList
        {
            get { return productList; }
            set
            {
                productList = value;
                NotifyChanged("ProductList");
            }
        }

        public void AddProduct(Products product)
        {
            ProductList.Add(product);
            NotifyChanged("ProductList"); // ObservableCollection이 업데이트되었음을 알립니다.
        }
    }
}
