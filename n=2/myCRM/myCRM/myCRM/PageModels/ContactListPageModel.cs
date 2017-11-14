using Acr.UserDialogs;
using myCRM.Models;
using myCRM.Services;
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

        IDataService _dataService;
        IUserDialogs _userDialogs;

        public ContactListPageModel (IDataService dataService, IUserDialogs userDialogs)
        {
            _dataService = dataService;
            _userDialogs = userDialogs;
        }

        public ContactListPageModel()
        {

        }

        public override async void Init (object initData)
        {
            base.Init(initData);

            _userDialogs.ShowLoading();

            ContactList = await _dataService.GetContacts();

            _userDialogs.HideLoading();
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