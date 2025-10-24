using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCsharpSena
{
    internal class Persona
    {
        // Atributos
        public string _nombre {  get; set; }
        public int _edad { get; set; }
        public char _genero { get; set; }
        public long _telefono { get; set; }


        // Constructor
        public Persona(string nombre, int edad, char genero, long telefono)
        {
            _nombre = nombre;
            _edad = edad;
            _genero = genero;
            _telefono = telefono;
        }

        //Metodos

        // Editar Informacion
        public void EditarInformacionUsuario()
        {
            Console.WriteLine($"La Informacion de Usuario ha Sido Modificado:");
            Console.WriteLine($"Nombre Nuevo de Usuario: {_nombre}");
            Console.WriteLine($"Edad Nueva del Usuario: {_edad}");
            Console.WriteLine($"Telefono Nuevo del Usuario: {_telefono}");
        }

        // Detalles Usuario
        public void DetallesUsuario()
        {
            Console.WriteLine("La Informacion del Usuario es la Siguiente:");
            Console.WriteLine($"Nombre Usuario: {_nombre}");
            Console.WriteLine($"Edad Usuario: {_edad}");
            Console.WriteLine($"Genero Usuario: {_genero}");
            Console.WriteLine($"Telefono Usuario: {_telefono}");
        }

        // Calcular Edad Usuario en Dias (Imprimir)
        public void EdadUsuarioEnDias()
        {
            int edadCalculada = _edad * 365;
            Console.WriteLine($"La edad: {_edad} en dias es de: {edadCalculada}");
        }
    }
}
