using PrimerosPasos.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Numerics;
using System.Text;
using Xamarin.Forms;

namespace PrimerosPasos.ViewModel
{
    public class ViewModelCarros : INotifyPropertyChanged
    {
        
        public ViewModelCarros() {

            ListaCarros = new ObservableCollection<Carros>();
            CarroSeleccionado = new Carros();

            CrearCarro = new Command(() =>
            {

                Carros c = new Carros()
                {

                    placa = this.placa,
                    modelo = this.modelo,
                    anio = this.anio,
                    color = this.color

                };


                ListaCarros.Add(c);

                App.Current.Properties["ListaCarros"] = ListaCarros;

            });


            CambioCarro = new Command( () => {

                Placa = carroSelecionado.placa;
                Modelo = carroSelecionado.modelo;
                Anio = carroSelecionado.anio;
                Color = carroSelecionado.color;


            } );


        }
        


        ObservableCollection<Carros> listaCarros = new ObservableCollection<Carros>();

        public ObservableCollection<Carros> ListaCarros {
            get => listaCarros;
            set { 
                
                listaCarros = value;
                var arg = new PropertyChangedEventArgs(nameof(ListaCarros));
                PropertyChanged?.Invoke(this, arg);

            }
        }

        string placa;
        public string Placa {
        
            get => placa;
            set { 
                placa = value;
                var arg = new PropertyChangedEventArgs(nameof(Placa));
                PropertyChanged?.Invoke(this, arg);

            }
        }

        string modelo;
        public string Modelo
        {

            get => modelo;
            set
            {
                modelo = value;
                var arg = new PropertyChangedEventArgs(nameof(Modelo));
                PropertyChanged?.Invoke(this, arg);

            }
        }

        string color;
        public string Color
        {

            get => color;
            set
            {
                color = value;
                var arg = new PropertyChangedEventArgs(nameof(Color));
                PropertyChanged?.Invoke(this, arg);

            }
        }

        int anio;
        public int Anio
        {

            get => anio;
            set
            {
                anio = value;
                var arg = new PropertyChangedEventArgs(nameof(Anio));
                PropertyChanged?.Invoke(this, arg);

            }
        }

        Carros carroSelecionado = new Carros();
        public Carros CarroSeleccionado {

            get => carroSelecionado;
            set {

                carroSelecionado = value;
                var arg = new PropertyChangedEventArgs(nameof(CarroSeleccionado));
                PropertyChanged?.Invoke(this, arg);
                

            }

        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Command CrearCarro { get; }
        public Command CambioCarro { get; }

    }
}
