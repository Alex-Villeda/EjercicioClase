using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase
{
    internal class Superpoder
    {
        public String? Nombre {  get; set; }

        public String? Descripcion { get; set; }

        public int ? Nivel { get; set; }

        //Constructor

        public Superpoder(String nombre, String descripcion, int nivel)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Nivel = nivel;
        }

        //Imprimir

        public void Imprimir()
        {
            Console.WriteLine($"Super Poder: ");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Descripcion: {Descripcion}");
            Console.WriteLine($"Nivel: {Nivel}");
            Console.WriteLine();
        }
    }
}
