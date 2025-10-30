using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Empleado
    {
        private string nombre;
        private string cargo;
        private double salario;

        // Constructor
        public Empleado(string nombre, string cargo, double salario)
        {
            this.nombre = nombre;
            this.cargo = cargo;
            this.salario = salario;
        }

        public class Gerente : Empleado
        {
            private double bono;

            public Gerente(string nombre, string cargo, double salario, double bono)
                : base(nombre, cargo, salario)
            {
                this.bono = bono;
            }

            // Mostrar salario con bono
            public void MostrarSalarioConBono()
            {
                double salarioTotal = ObtenerSalario() + bono;
                Console.WriteLine($"Salario total (con bono): {salarioTotal:C}");
            }
        }

        // Métodos públicos
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Cargo: {cargo}");
        }

        // Método protegido para que las subclases puedan acceder al salario
        protected double ObtenerSalario()
        {
            return salario;
        }

        // Método privado (solo el área administrativa puede modificar)
        private void ModificarSalario(double nuevoSalario)
        {
            salario = nuevoSalario;
        }

        // Método público que controla la modificación
        public void ActualizarSalario(double nuevoSalario, bool esAdministrativo)
        {
            if (esAdministrativo)
            {
                ModificarSalario(nuevoSalario);
                Console.WriteLine("El salario ha sido actualizado por el área administrativa.");
            }
            else
            {
                Console.WriteLine("No tiene permiso para modificar el salario.");
            }
        }
    }
}