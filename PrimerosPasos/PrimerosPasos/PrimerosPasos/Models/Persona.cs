using System;
using System.Collections.Generic;
using System.Text;

namespace PrimerosPasos.Models
{
    [Serializable]
    public class Persona
    {

        public string nombre { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public double estatura { get; set; }
        public List<Carros> CarrosPersona { get; set; } = new List<Carros>();

        public int calcularEdad() {

            DateTime hoy = DateTime.Now;

            int anios = hoy.Year -  fechaNacimiento.Year;

            if (hoy.Month < fechaNacimiento.Month) {

                anios = anios - 1;
            }
            return anios;
        }

        public override string ToString()
        {
            return $"{nombre} - {calcularEdad()} ";
        }

    }
}
