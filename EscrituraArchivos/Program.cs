using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace EscrituraArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt" , true); //Para sobreescribir es false, para escribir es true
                                                               //se utiliza una "," despues del documento. 
            //Si el archivo no existe lo crea
            //Si ya existe, escribira en el


            string[] lines =
            {
                "Esta es la informacion de la primera linea.",
                "Esta es la segunda linea",
                "Fin del texto"
            };


            foreach(string line in lines)
            {
                sw.WriteLine(line);
            }
            sw.Close(); //Cierre del archivo, se debe de hacer

            Console.WriteLine("Escribiendo en el archivo...");
            Console.ReadKey();
        }
    }
}
