using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PED.Models;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace PED.ViewModels
{
    public class ProvaViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<ProvaModel> ProvaItems { get; set; }

        public ProvaViewModel()
        {
            ProvaItems = new ObservableCollection<ProvaModel>(new []
            {
                new ProvaModel { Id = 0, Ano = 2016},
                new ProvaModel { Id = 1, Ano = 2015},
                new ProvaModel { Id = 2, Ano = 2014},
                new ProvaModel { Id = 3, Ano = 2013},
                new ProvaModel { Id = 4, Ano = 2012},
                new ProvaModel { Id = 5, Ano = 2011},
                new ProvaModel { Id = 6, Ano = 2010},
                new ProvaModel { Id = 7, Ano = 2009},
                new ProvaModel { Id = 8, Ano = 2008},
                new ProvaModel { Id = 9, Ano = 2007},
                new ProvaModel { Id = 10, Ano = 2006},
                new ProvaModel { Id = 11, Ano = 2005},
                new ProvaModel { Id = 12, Ano = 2004},
                new ProvaModel { Id = 13, Ano = 2003},
                new ProvaModel { Id = 14, Ano = 2002},
                new ProvaModel { Id = 15, Ano = 2001},
                new ProvaModel { Id = 16, Ano = 2000},
                new ProvaModel { Id = 17, Ano = 1999},
                new ProvaModel { Id = 18, Ano = 1998},
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
