using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PED.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PED.ViewModels;

namespace PED.Views.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailMainMaster : ContentPage
    {
        public ListView ListView
        {
            get
            {
                return MenuItemsListView;
            }
        }

        public MasterDetailMainMaster()
        {
            InitializeComponent();

            BindingContext = new MasterDetailMainMasterViewModel();
            // ListView = MenuItemsListView;
        }
    }
}