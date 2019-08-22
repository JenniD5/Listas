using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colores =
                new List<string>();

            colores.Add("rojo");   //0
            colores.Add("azul");   //1
            colores.Add("verde");//2
            colores.Add("amarillo");//3
            colores.Add("morado");//agregar 

            colores.RemoveAt(2);//borrar por el indice 
            colores.Remove("amarillo"); //para borrar un elemento especifico, pasandole el elementos especifico


            //**Console.WriteLine("numero de elementos: " + colores.Count);conocer el numero de los elementos en la lista
            //Console.WriteLine("elemento1=" + colores[0]);como si fuera arreglo
            //Console.WriteLine("elemento2=" + colores[1]);
            // Console.WriteLine("elemento3=" + colores[2]);
            // Console.WriteLine("elemento4=" + colores[3]);



            int IndiceColor = 1; //contador
            foreach(string color in colores)
            {
                Console.WriteLine(
                    "elemento" + IndiceColor.ToString() + ":" + color);
                IndiceColor++;

            }


            
            Console.Read();
               
        }
    }
}
