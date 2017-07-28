using PED.Views;
using PED.Views.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PED.ViewModels
{
    class MasterDetailMainMasterViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<MasterDetailMainMenuItem> MenuItems { get; set; }

        public MasterDetailMainMasterViewModel()
        {
            MenuItems = new ObservableCollection<MasterDetailMainMenuItem>(new[]
            {
                    new MasterDetailMainMenuItem { Id = 0, Title = "Home", TargetType = typeof(HomeView) },
                    new MasterDetailMainMenuItem { Id = 1, Title = "Novo Simulado", TargetType = typeof(NovoSimuladoView) },
                    new MasterDetailMainMenuItem { Id = 2, Title = "Histórico", TargetType = typeof(HistoricoView) },
                    new MasterDetailMainMenuItem { Id = 3, Title = "Gráfico de Acertos", TargetType = typeof(GraficoView) },
                    new MasterDetailMainMenuItem { Id = 4, Title = "Questões Comentadas", TargetType = typeof(QuestoesView) },
                    new MasterDetailMainMenuItem { Id = 5, Title = "Configurações", TargetType = typeof(ConfiguracoesView) },
                    new MasterDetailMainMenuItem { Id = 6, Title = "Contato", TargetType = typeof(ContatoView)},
                    new MasterDetailMainMenuItem { Id = 7, Title = "Sair" },
                });
        }

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
