﻿using myCRM.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace myCRM
{
    public partial class App : Application
    {
        public App()
        {
            var contactList = FreshMvvm.FreshPageModelResolver.ResolvePageModel<ContactListPageModel>();
            var navContainer = new FreshMvvm.FreshNavigationContainer(contactList);
            MainPage = navContainer;
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
