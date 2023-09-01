using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WPFSample_YSLee.Model
{
    class ViewModel_Test : Notifier_Test
    {
        string discription  = string.Empty;
        string startPrice   = string.Empty; bool isPriceErr = false;
        string startDate    = string.Empty;

        public string Discription
        {
            get { return discription; }
            set
            {
                discription = value;
                //
                NotifyChanged("Discription");
            }
        }
        public string StartDate
        {
            get { return startDate; }
            set
            {
                startDate = value;
                //
                NotifyChanged("StartDate");
            }
        }

        public string StartPrice
        {
            get { return startPrice; }
            set
            {
                if (Regex.IsMatch(value, "^[0-9]*$"))
                {
                    startPrice = value;
                    Console.WriteLine("False");
                }
                else
                {
                    startPrice = value;
                    Console.WriteLine("True");
                }
                NotifyChanged("StartPrice");
            }
        }
    }
}
