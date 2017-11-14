using myCRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace myCRM.PageModels
{
    public class ContactListPageModel : FreshMvvm.FreshBasePageModel
    {
        public List<Contact> ContactList { get; set; }
        public ContactListPageModel()
        {
            
        }

        public override void Init (object initData)
        {
            base.Init(initData);

            ContactList = new List<Contact>
            {
                new Contact {Name = "Peter", Number = "239847"},
                new Contact {Name = "Peter", Number = "239847"}
            };
        }

        public Contact SelectedContact
        {
            get { return null; }
            set
            {
                CoreMethods.PushPageModel<ContactPageModel>(value);
                RaisePropertyChanged();
            }
        }
    }
}