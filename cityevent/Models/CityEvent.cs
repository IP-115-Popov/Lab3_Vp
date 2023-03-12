using Avalonia;
using Avalonia.Utilities;
using DynamicData.Binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cityevent.Models
{
    public class CityEvent : AbstractNotifyPropertyChanged
    {
        private string header = "";
        private string? description = "";
        private string image = "";
        private string date = "";
        private int category = 0;
        private string price = "0";

        public CityEvent() { }

        private static string? CheckDescLength(string? desc)
        {
            if(desc != null && desc != "")
            {
                if (desc.Length > 135)
                {
                    desc = desc[..132];
                    desc += "...";
                }
            }
            return desc;
        }

        public string Header
        {
            get => header;
            set => SetAndRaise(ref header, value);
        }

        public string? Description
        {
            get => description;
            set => SetAndRaise(ref description, CheckDescLength(value));
        }
        public string Image
        {
            get => image;
            set => SetAndRaise(ref image, value);
        }
        public string Date
        {
            get => date;
            set => SetAndRaise(ref date, value);
        }
        public int Category
        {
            get => category;
            set => SetAndRaise(ref category, value);
        }
        public string Price
        {
            get => price;

            set 
            {
                    SetAndRaise(ref price, value + "₽");
            } 
            
        }
    }
}
