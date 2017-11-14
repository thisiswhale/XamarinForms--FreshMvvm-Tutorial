using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace myCRM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Contact 
    {
        public string Name { get; set; }
        public string Number { get; set; }

    }
}