using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using myCRM.PageModels;
using myCRM.Services;
using Acr.UserDialogs;

namespace myCRM
{
    public partial class App : Application
    {
        public App()
        {
            SetupIOC();

            var contactList = FreshMvvm.FreshPageModelResolver.ResolvePageModel<ContactListPageModel>();
            var navContainer = new FreshMvvm.FreshNavigationContainer(contactList);
            MainPage = navContainer;
        }

        void SetupIOC()
        {
            FreshMvvm.FreshIOC.Container.Register<IDataService, DataService>();
            FreshMvvm.FreshIOC.Container.Register<IUserDialogs>(UserDialogs.Instance);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
