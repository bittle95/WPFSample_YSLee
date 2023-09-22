using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace WPFSample_YSLee.Model
{
    //AddProductListingView에서 MainView로 데이터를 내보내기 위한 클래스
    public class Products
    {
        public Products(Model.ViewModel viewModel)
        {
            Discription = viewModel.Discription;
            StartPrice = viewModel.StartPrice;
            StartDate = viewModel.StartDate;
            Category = viewModel.Category;
            Special_Feature = viewModel.Special_Feature;
            Thickness = viewModel.Thickness;
            BorderColor = viewModel.BorderColor;
            IsBargain = viewModel.IsBargain;
            MemberSince = viewModel.MemberSince;
            OwnersName = viewModel.OwnersName;
            OwnersRating = viewModel.OwnersRating;
            //ImagePath = viewModel.ImagePath;
        }
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

        private Thickness thickness;
        public Thickness Thickness
        {
            get { return thickness; }
            set
            {
                thickness = value;
            }
        }

        private SolidColorBrush borderColor;
        public SolidColorBrush BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
            }
        }

        private bool isbargain;
        public bool IsBargain
        {
            get { return isbargain; }
            set
            {
                isbargain = value;
            }
        }

        private double ownersRating;
        public double OwnersRating
        {
            get { return ownersRating; }
            set
            {
                ownersRating = value;
            }
        }

        private string memberSince;
        public string MemberSince
        {
            get { return memberSince; }
            set
            {
                memberSince = value;
            }
        }

        private string ownersName;
        public string OwnersName
        {
            get { return ownersName; }
            set
            {
                ownersName = value;
            }
        }

        //private string imagePath;
        //public string ImagePath
        //{
        //    get { return imagePath; }
        //    set
        //    {
        //        imagePath = value;
        //    }
        //}
    }
}
