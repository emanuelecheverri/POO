using System;
using System.Collections.Generic;
using static POO.Empleado;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Caso Estudio 1
            //// Ingreso datos Marca y Modelo
            //Console.WriteLine("Ingresa la Marca del Vehiculo uno");
            //string IngresoMarca = Console.ReadLine();
            //Console.WriteLine("Ingresa el Modelo del Vehiculo uno");
            //string IngresoModelo = Console.ReadLine();

            //// Objetos
            //Vehiculo.Camion camion1 = new Vehiculo.Camion(IngresoMarca, IngresoModelo, 10000);
            //camion1.MostrarInformacion();

            //Console.WriteLine("Ingresa la Marca del Vehiculo dos");
            //string IngresoMarca2 = Console.ReadLine();
            //Console.WriteLine("Ingresa el Modelo del Vehiculo dos");
            //string IngresoModelo2 = Console.ReadLine();

            //Vehiculo.Camion camion2 = new Vehiculo.Camion(IngresoMarca2, IngresoModelo2, 10000);
            //camion2.MostrarInformacion();


            //Caso Estudio 2

            //Console.Write("Ingrese el número de empleados: ");
            //int cantidad = int.Parse(Console.ReadLine());

            //Empleado[] empleados = new Empleado[cantidad];

            //for (int i = 0; i < cantidad; i++)
            //{
            //    Console.WriteLine($"\nEmpleado #{i + 1}");
            //    Console.Write("¿Es gerente? (s/n): ");
            //    string tipo = Console.ReadLine().ToLower();

            //    Console.Write("Nombre: ");
            //    string nombre = Console.ReadLine();

            //    Console.Write("Cargo: ");
            //    string cargo = Console.ReadLine();

            //    Console.Write("Salario: ");
            //    double salario = double.Parse(Console.ReadLine());

            //    if (tipo == "s")
            //    {
            //        Console.Write("Ingrese el bono del gerente: ");
            //        double bono = double.Parse(Console.ReadLine());
            //        empleados[i] = new Gerente(nombre, cargo, salario, bono);
            //    }
            //    else
            //    {
            //        empleados[i] = new Empleado(nombre, cargo, salario);
            //    }
            //}

            //Console.WriteLine("\n Información de empleados ");
            //foreach (Empleado emp in empleados)
            //{
            //    emp.MostrarInformacion();

            //    if (emp is Gerente gerente)
            //    {
            //        gerente.MostrarSalarioConBono();
            //    }

            //}

            //// Ejemplo de actualización de salario
            //Console.Write("\n¿Desea modificar el salario del primer empleado? (s/n): ");
            //if (Console.ReadLine().ToLower() == "s")
            //{
            //    Console.Write("Ingrese el nuevo salario: ");
            //    double nuevoSalario = double.Parse(Console.ReadLine());
            //    Console.Write("¿Es administrativo? (s/n): ");
            //    bool admin = Console.ReadLine().ToLower() == "s";

            //    empleados[0].ActualizarSalario(nuevoSalario, admin);
            //}

            //Console.WriteLine("\nFin del programa");

            //Caso Estudio 3

            List<Libro> biblioteca = new List<Libro>();

            Console.WriteLine("Bienvenido al sistema de Biblioteca Digital\n");

            Console.Write("¿Cuántos libros deseas registrar?: ");
            int cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"\nLibro #{i + 1}");
                Console.Write("¿Es un libro digital? (s/n): ");
                string tipo = Console.ReadLine().ToLower();

                Console.Write("Título: ");
                string titulo = Console.ReadLine();

                Console.Write("Autor: ");
                string autor = Console.ReadLine();

                Console.Write("Número de páginas: ");
                int paginas = int.Parse(Console.ReadLine());

                if (tipo == "s")
                {
                    Console.Write("Tamaño del archivo (MB): ");
                    double tamano = double.Parse(Console.ReadLine());

                    biblioteca.Add(new LibroDigital(titulo, autor, paginas, tamano));
                }
                else
                {
                    biblioteca.Add(new Libro(titulo, autor, paginas));
                }
            }

            Console.Clear();
            Console.WriteLine("Catálogo de libros registrados:\n");

            foreach (var libro in biblioteca)
            {
                if (libro is LibroDigital digital)
                {
                    Console.WriteLine(digital.MostrarResumen());
                }
                else
                {
                    Console.WriteLine($"Título: {libro.GetTitulo()} | Autor: {libro.GetAutor()} | Páginas: {libro.GetPaginas()}");
                }
            }

            Console.WriteLine("\n¿Deseas actualizar las páginas de algún libro? (s/n): ");
            string opcion = Console.ReadLine().ToLower();

            if (opcion == "s")
            {
                Console.Write("Título del libro a actualizar: ");
                string tituloBuscar = Console.ReadLine();

                foreach (var libro in biblioteca)
                {
                    if (libro.GetTitulo().Equals(tituloBuscar, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Write("Nueva cantidad de páginas: ");
                        int nuevasPaginas = int.Parse(Console.ReadLine());
                        libro.ActualizarPaginasPersonal(nuevasPaginas);
                        Console.WriteLine("Páginas actualizadas correctamente.");
                    }
                }
            }

            Console.WriteLine("\nDatos finales de la biblioteca:\n");
            foreach (var libro in biblioteca)
            {
                if (libro is LibroDigital digital)
                {
                    Console.WriteLine(digital.MostrarResumen());
                }
                else
                {
                    Console.WriteLine($"Título: {libro.GetTitulo()} | Autor: {libro.GetAutor()} | Páginas: {libro.GetPaginas()}");
                }
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
    }
}
