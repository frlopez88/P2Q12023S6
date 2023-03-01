using PrimerosPasos.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace PrimerosPasos.ViewModel
{
    public class ViewModelPersonaCarro : INotifyPropertyChanged
    {

        public ViewModelPersonaCarro() {


            try {

                listaCarros = App.Current.Properties["ListaCarros"] as ObservableCollection<Carros>;
                listaPersonas = App.Current.Properties["ListaPersonas"] as ObservableCollection<Persona>;

            }
            catch (Exception ex)
            {


            }


            AsignarCarro = new Command(() => {

                peronaSeleccionada.CarrosPersona.Add(carroSeleccionado);
                int i = 0;
                i = i + 1;
            
            } );



        }


        Persona peronaSeleccionada = new Persona();
        public Persona PersonaSeleccionada {
            get => peronaSeleccionada;
            set { 
            
                peronaSeleccionada = value;
                var arg = new PropertyChangedEventArgs(nameof(PersonaSeleccionada));
                PropertyChanged?.Invoke(this, arg);

            }

        }


        Carros carroSeleccionado = new Carros();
        public Carros CarroSeleccionado
        {
            get => carroSeleccionado;
            set
            {

                carroSeleccionado = value;
                var arg = new PropertyChangedEventArgs(nameof(CarroSeleccionado));
                PropertyChanged?.Invoke(this, arg);

            }

        }


        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Carros> listaCarros { get; set; } = new ObservableCollection<Carros>();
        public ObservableCollection<Persona> listaPersonas { get; set; } = new ObservableCollection<Persona>();


        public Command AsignarCarro { get; }
    }
}
