using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PrimerosPasos.Models
{

    [Serializable]
    public class Carros
    {
        public string placa { get; set; }
        public string modelo { get; set; }
        public string color { get; set; }
        public int anio { get; set; }
        public List<Carros> carros { get; set; } = new List<Carros>();

        public override string ToString()
        {
            return $"{placa} - {modelo} ";
        }
    }
}
