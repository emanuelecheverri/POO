using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Vehiculo
    {
        private string _marca;
        private string _modelo;
        private double _kilimetraje;

        public Vehiculo(string marca, string modelo, double kilimetraje)
        {
            _marca = marca;
            _modelo = modelo;
            _kilimetraje = kilimetraje;
        }

        public class Camion : Vehiculo
        {
            public Camion(string marca, string modelo, double kilimetraje)
                : base(marca, modelo, kilimetraje)
            {
            }
        }

        protected double CalcularCostoMantenimiento()
        {
            if (_kilimetraje < 100000)
            {
                return 100000;
            }
            else if (_kilimetraje < 500000)
            {
                return 300000;
            }
            else
            {
                return 500000;
            }

            
        }   
        public void MostrarInformacion()
        {
            Console.WriteLine($"Marca: {_marca}");
            Console.WriteLine($"Modelo: {_modelo}");
            Console.WriteLine($"Kilometraje: {_kilimetraje} km");
            Console.WriteLine($"Costo de Mantenimiento: {CalcularCostoMantenimiento()}");
        }
    }
}
