using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCsharpSena
{
    internal class Libro
    {
        public int _id {  get; set; }
        public string _titulo {  get; set; }
        public string _autor {  get; set; }
        public string _editorial { get; set; }
        public string _anioPublicacion { get; set; }

        public Libro(int id, string titulo, string autor, string editorial, string anioPublicacion)
        {
            _id = id;
            _titulo = titulo;
            _autor = autor;
            _editorial = editorial;
            _anioPublicacion = anioPublicacion;
        }
        // Clase Biblioteca
        public class Biblioteca
        {

            // Lista
            public List<Libro> LibrosLista = new List<Libro>();

            // Metodos

            // Agregar Libros
            public void AgregarLibro()
            {
                // Id Se Agrega Solo
                int siguienteId = 1;
                //Titulo Libro
                Console.WriteLine($"Ingresa el TItulo del Libro: ");
                string tituloLibro = Console.ReadLine();

                // Autor Libro
                Console.WriteLine($"Ingresa el Nombre del Autor del Libro: ");
                string autorLibro = Console.ReadLine();

                // Editorial Libro
                Console.WriteLine($"Ingresa la Editorial del Libro");
                string editorialLibro = Console.ReadLine();

                // Año de Publicacion
                Console.WriteLine("Ingresa el Año de Publicacion del Libro (Dia/Mes/Año): ");
                string anioPublicacionLibro = Console.ReadLine();

                // Objeto
                Libro nuevoLibro = new Libro(siguienteId++, tituloLibro, autorLibro, editorialLibro, anioPublicacionLibro);
                // Agregar a la Lista
                LibrosLista.Add(nuevoLibro);
            }

            // Listar Libros
            public void ListarLibros()
            {
                foreach (var libro in LibrosLista)
                {
                    Console.WriteLine($"ID: {libro._id}, Titulo: {libro._titulo}, Editorial Libro:{libro._editorial},  Año de Publicacion: {libro._anioPublicacion}");
                }
            }
        }
    }

 
}
