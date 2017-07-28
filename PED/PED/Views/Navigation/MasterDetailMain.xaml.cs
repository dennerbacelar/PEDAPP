﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PED.Views.Navigation;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PED.Views.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailMain : MasterDetailPage
    {
        public MasterDetailMainMaster MasterPage;
        public MasterDetailMain()
        {
            InitializeComponent();
            MasterPage = new MasterDetailMainMaster();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
            this.Master = MasterPage;
            this.Detail = new NavigationPage(new HomeView());
        }

         void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterDetailMainMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}