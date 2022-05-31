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


            //Variable 
            string[] lines = new string[2];
            int[] e = new int[1];
            
            //Captura de variables
            Console.Write("Introduce tu(s) nombre(s): ");
            lines[0] = Console.ReadLine();

            Console.Write("Introduce tu(s) apellido(s): ");
            lines[1] = Console.ReadLine();


            foreach (string line in lines)
            {
                sw.WriteLine(line);
            }
            sw.Close(); //Cierre del archivo, se debe de hacer

            Console.WriteLine("Escribiendo en el archivo...");
            Console.ReadKey();
        }
    }
}
