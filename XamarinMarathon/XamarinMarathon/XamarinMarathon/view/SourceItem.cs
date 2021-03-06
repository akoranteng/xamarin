﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.Common.DataAnnotations;

namespace XamarinMarathon.view
{
    public class SourceItem : NotifyPropertyChangedBase
    {
        string name = "Anna";
        double weight = 60.5;
        int height = 163;
        int age = 27;

        [DisplayOptions(Header = "Name")]
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value != this.name)
                {
                    this.name = value;
                    OnPropertyChanged();
                }
            }
        }

        [DisplayOptions(Header = "Age")]
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value != this.age)
                {
                    this.age = value;
                    OnPropertyChanged();
                }
            }
        }

        [DisplayOptions(Header = "Weight (kg)")]
        public double Weight
        {
            get { return this.weight; }
            set
            {
                if (value != this.weight)
                {
                    this.weight = value;
                    OnPropertyChanged();
                }
            }
        }

        [DisplayOptions(Header = "Height (cm)")]
        public int Height
        {
            get { return this.height; }
            set
            {
                if (value != this.height)
                {
                    this.height = value;
                    OnPropertyChanged();
                }
            }
        }

        private void OnPropertyChanged()
        {
            //throw new NotImplementedException();
        }
    }
}
