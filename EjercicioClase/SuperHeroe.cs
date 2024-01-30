using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase
{
    internal class SuperHeroe
    {
       
        public String? Nombre { get; set; }
        public String? IdentidadSecreta { get; set; }
        public String? Ciudad { get; set; }
        public bool? PuedeVolar { get; set; }
        public Superpoder? Superpoder { get; set; } // Asegúrate de tener una propiedad Superpoder

        public SuperHeroe(string nombre, string identidasecreta, string ciudad, bool puedevolar, Superpoder superpoder)
        {
            Nombre = nombre;
            IdentidadSecreta = identidasecreta;
            Ciudad = ciudad;
            PuedeVolar = puedevolar;
            Superpoder = superpoder;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"IdentidadSecreta: {IdentidadSecreta}");
            Console.WriteLine($"Ciudad: {Ciudad}");
            Console.WriteLine($"PuedeVolar: {PuedeVolar}");

            // Accede a los atributos del Superpoder utilizando la propiedad Superpoder
            
            Console.WriteLine($"Nombre: {Superpoder.Nombre}");
            Console.WriteLine($"Descripción: {Superpoder.Descripcion}");
            Console.WriteLine($"Nivel: {Superpoder.Nivel}");
        }
    }
}