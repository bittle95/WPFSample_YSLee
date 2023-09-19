using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace WPFSample_YSLee.Model
{
    //AddProductListingView 내에서만 바인딩하기 위한 뷰모델
    public class ViewModel : Notifier
    {
        //기본 세팅 데이터
        string discription = "Please enter a description";
        double startPrice = 100;
        string startDate = DateTime.Now.ToString("yyyy-MM-dd");
        string category = "DVS's";
        string special_Features = "None";

        //새 창을 켤때마다 초기화
        public void SetInitialProductValue()
        {
            Discription = "Please enter a description";
            StartPrice = 100;
            StartDate = DateTime.Now.ToString("yyyy-MM-dd");
            Category = "DVS's";
            Special_Feature = "None";
            BorderColor = Brushes.Black;
        }

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
                    //Console.WriteLine("True");
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

        private Thickness thickness;
        public Thickness Thickness
        {
            get { return thickness; }
            set
            {
                thickness = value;
                NotifyChanged("Thickness");
            }
        }
        
        private SolidColorBrush borderColor;
        public SolidColorBrush BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value; 
                NotifyChanged("BorderColor");
            }
        }

        private bool isbargain;
        public bool IsBargain
        {
            get { return isbargain; }
            set
            {
                isbargain = value; 
                NotifyChanged("IsBargain");
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

        // ObservableCollection 업데이트
        public void AddProduct(Products product)
        {
            ProductList.Add(product);
            NotifyChanged("ProductList"); 
        }
    }
}
