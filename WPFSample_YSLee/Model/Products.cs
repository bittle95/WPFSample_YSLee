using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSample_YSLee.Model
{
    public class Products : Notifier
    {
        private string discription;
        public string Discription
        {
            get { return discription; }
            set
            {
                discription = value;
                NotifyChanged("Discription");
            }
        }

        private double startPrice;
        public double StartPrice
        {
            get { return startPrice; }
            set
            {
                startPrice = value;
                NotifyChanged("StartPrice");
            }
        }

        private string startDate;
        public string StartDate
        {
            get { return startDate; }
            set
            {
                startDate = value;
                NotifyChanged("StartDate");
            }
        }

        private string category;
        public string Category
        {
            get { return category; }
            set
            {
                category = value;
                NotifyChanged("Category");
            }
        }

        private string special_Feature;
        public string Special_Feature
        {
            get { return special_Feature; }
            set
            {
                special_Feature = value;
                NotifyChanged("Special_Feature");
            }
        }
    }
}
