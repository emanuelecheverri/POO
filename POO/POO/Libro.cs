using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Libro
    {
        private string titulo;
        private string autor;
        private int paginas;

        // Constructor
        public Libro(string titulo, string autor, int paginas)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.paginas = paginas;
        }

        // Métodos públicos para consultar los datos del libro
        public string GetTitulo()
        {
            return titulo;
        }

        public string GetAutor()
        {
            return autor;
        }

        public int GetPaginas()
        {
            return paginas;
        }

        // Método privado: solo accesible dentro de esta clase
        private void ActualizarPaginas(int nuevasPaginas)
        {
            paginas = nuevasPaginas;
        }

        // Método protegido: accesible por esta clase y sus derivadas
        protected string GenerarResumen()
        {
            return $"\"{titulo}\" de {autor}, {paginas} páginas.";
        }

        // Método público para permitir la actualización controlada (por el personal)
        public void ActualizarPaginasPersonal(int nuevasPaginas)
        {
            Console.WriteLine("Actualizando cantidad de páginas (solo personal autorizado)...");
            ActualizarPaginas(nuevasPaginas);
        }
    }

    // Clase derivada: LibroDigital
    class LibroDigital : Libro
    {
        private double tamanoArchivo; // en MB

        // Constructor
        public LibroDigital(string titulo, string autor, int paginas, double tamanoArchivo)
            : base(titulo, autor, paginas)
        {
            this.tamanoArchivo = tamanoArchivo;
        }

        // Método público que usa el método protegido de la clase base
        public string MostrarResumen()
        {
            string resumenBase = GenerarResumen(); // uso del método protegido
            return $"{resumenBase} Tamaño del archivo: {tamanoArchivo} MB.";
        }
    }
}

