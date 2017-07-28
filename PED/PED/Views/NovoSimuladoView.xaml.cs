using PED.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PED.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NovoSimuladoView : ContentPage
    { 
        public NovoSimuladoView()
        {
            InitializeComponent();
            BindingContext = new ProvaViewModel();
        }
    }
}