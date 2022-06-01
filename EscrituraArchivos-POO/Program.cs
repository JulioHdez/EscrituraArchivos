using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace EscrituraArchivos_POO
{
    public class Equipo
    {
        //Campos de la clase
        public string nombre, apellido, talla, espalda;
        public int num;

        ////Constructor
        //public Equipo(string nombre, string apellido, string talla, int num, string espalda)
        //{
        //    this.nombre = nombre;
        //    this.apellido = apellido;
        //    this.talla = talla;
        //    this.num = num;
        //    this.espalda = espalda;
        //}


        //Metodo de la clase
        public virtual void Camiseta()
        {
            Console.WriteLine("El nombre del jugador es: {0}" , nombre);
            Console.WriteLine("El apellido del jugador es: {0}", apellido);
            Console.WriteLine("El número elegido por el jugador {0} es: {1}" , nombre , num);
            Console.WriteLine("La talla del jugador es: {0}" , talla);
            Console.WriteLine("En la parte trasera de la camiseta se mostrará lo siguiente: '{0}' junto al número elegido ({1})." , espalda , num);
        }
    }

    //clase derivada
    public class Galgos : Equipo
    {
        //Campos de la clase derivada
        public string escuela;

        //Constructor
        public Galgos(string nombre, string apellido, string talla, int num, string espalda,string escuela) :base()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.talla = talla;
            this.num = num;
            this.espalda = espalda;
            this.escuela = escuela;
        }

    public override void Camiseta()
        {
            Console.WriteLine("El nombre del jugador es: {0}", nombre);
            Console.WriteLine("El apellido del jugador es: {0}", apellido);
            Console.WriteLine("El número elegido por el jugador {0} es: {1}", nombre, num);
            Console.WriteLine("La talla del jugador es: {0}", talla);
            Console.WriteLine("En la parte trasera de la camiseta se mostrará lo siguiente: '{0}' junto al número elegido ({1}).", espalda, num);
            Console.WriteLine("El Jugador pertence a la escuela: {0}" , escuela); 
            
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //Creacion del archivo
            StreamWriter sw = new StreamWriter("Camisetas Deportivas.txt" , true);
            
            //Variables auxiliares
            string nombre, apellido, talla, espalda;
            int num;

            
            Console.Write("Ingresa tu nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingresa tu apellido: ");
            apellido = Console.ReadLine();

            Console.Write("Ingresa tu talla: ");
            talla = Console.ReadLine();

            Console.Write("Ingresa tu número para tu camiseta: ");
            num = int.Parse(Console.ReadLine());

            Console.Write("Ingresa lo que decidas llevar en la espalda de la camiseta: ");
            espalda = Console.ReadLine();

            //Limpieza de pantalla
            Console.Clear();

            //Creacion del objeto
            Galgos galgos = new Galgos(nombre, apellido, talla, num, espalda, "ITT");

            //Invoque de metodo
            galgos.Camiseta();

            sw.WriteLine("Jugador: " +galgos.nombre + " " + galgos.apellido + "\tTalla: " + galgos.talla + "\tNúmero: " + galgos.num + "\tEspalda: " + galgos.espalda);
            sw.Close();

            Console.WriteLine("Presiona ENTER para continuar...");
            Console.ReadKey();

        }
    }
}
