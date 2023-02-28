using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using PrimerosPasos.Models;
using System.Collections.ObjectModel;

namespace PrimerosPasos.ViewModel
{
    public class ViewModelPersona : INotifyPropertyChanged
    {


        public ViewModelPersona() {

            ListaPersonas = new ObservableCollection<Persona>();

            CrearPersona = new Command(
                
                    () => { 
                        
                        Persona p = new Persona() { 
                        
                            nombre = this.nombre, 
                            fechaNacimiento = this.fechaNacimiento,
                            estatura = this.estaturaMetros
                        
                        };


                        Mensaje = p.ToString();
                        ListaPersonas.Add(p);
                        
                    }
                
                
                );


        }

        string mensaje;

        public string Mensaje {

            get => mensaje;
            set { 
            
                mensaje = value;
                var arg = new PropertyChangedEventArgs(nameof(Mensaje));
                PropertyChanged?.Invoke(this, arg);

            }
        
        }

        string nombre;

        public string Nombre {

            get => nombre;
            set { 
            
                nombre = value;
                var arg = new PropertyChangedEventArgs( nameof(Nombre) );
                PropertyChanged?.Invoke(this, arg);


            }

        }

        DateTime fechaNacimiento;

        public DateTime FechaNacimiento { 
        
            get => fechaNacimiento; 
            set { 
                fechaNacimiento= value;
                var arg = new PropertyChangedEventArgs(nameof(FechaNacimiento));
                PropertyChanged?.Invoke(this, arg);
            }
        
        }

        double estaturaMetros;

        public double EstaturaMetros
        {

            get=> estaturaMetros;
            set {
                estaturaMetros = value;
                var arg = new PropertyChangedEventArgs(nameof(EstaturaMetros));
                PropertyChanged?.Invoke(this, arg);
            }

        }

        public DateTime FechaMinima { get; set; } = new DateTime(1980, 1, 1); 

        ObservableCollection<Persona> listaPersonas = new ObservableCollection<Persona>();

        public ObservableCollection<Persona> ListaPersonas {

            get => listaPersonas;
            set { 
            
                listaPersonas = value;
                var arg = new PropertyChangedEventArgs(nameof(ListaPersonas));
                PropertyChanged?.Invoke(this, arg);
            }
        }

        public Command CrearPersona { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
