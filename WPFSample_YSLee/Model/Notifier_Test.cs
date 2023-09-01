﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSample_YSLee.Model
{
    class Notifier_Test : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void NotifyChanged(params string[] propertyNames)
        {
            foreach (string name in propertyNames)
            {
                OnPropertyChanged(new PropertyChangedEventArgs(name));
            }
        }

        private void OnPropertyChanged(PropertyChangedEventArgs propertyChangedEventArgs)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, propertyChangedEventArgs);
            }
        }
    }
}
