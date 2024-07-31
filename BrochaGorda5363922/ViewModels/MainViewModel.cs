using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrochaGorda5363922.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        public String nombre;

        [ObservableProperty]
        public double tamaño;

        [ObservableProperty]
        public double precio; 
        
        [ObservableProperty]
        public string costoTotal;

        [RelayCommand]

        private void Presupuesto()
        {
            double total = Tamaño * 2.00;
            CostoTotal = $" $ {total:F2}";
            string nombre = Nombre;
        }
    }
}
