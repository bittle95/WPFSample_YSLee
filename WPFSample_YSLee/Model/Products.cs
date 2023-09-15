using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSample_YSLee.Model
{
    //AddProductListingView에서 MainView로 데이터를 내보내기 위한 클래스
    public class Products
    {
        private string discription;
        public string Discription
        {
            get { return discription; }
            set
            {
                discription = value;
            }
        }

        private double startPrice;
        public double StartPrice
        {
            get { return startPrice; }
            set
            {
                startPrice = value;
            }
        }

        private string startDate;
        public string StartDate
        {
            get { return startDate; }
            set
            {
                startDate = value;
            }
        }

        private string category;
        public string Category
        {
            get { return category; }
            set
            {
                category = value;
            }
        }

        private string special_Feature;
        public string Special_Feature
        {
            get { return special_Feature; }
            set
            {
                special_Feature = value;
            }
        }
    }
}
