using matrices.Clases;
using matrices.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserte la longitud del arreglo:");
            int longitud = Convert.ToInt32(Console.ReadLine());

            VideoJuegoModel videojuego = new VideoJuegoModel();
            Matriz matriz = new Matriz(longitud);

            Console.WriteLine("seleccione una opcion");
            Console.WriteLine("1._ salir");
            Console.WriteLine("2._ añadir al inicio");
            Console.WriteLine("3._ añadir al medio");
            Console.WriteLine("4._ obtener un elemento por su nombre");
            Console.WriteLine("5._obtener todos los elementos");
            Console.WriteLine("6._saber la longitud del arreglo");
            Console.WriteLine("7._ eliminar");

            int opcion = Convert.ToInt32(Console.ReadLine());   

            while (opcion != 1)
            {
                switch(opcion)
                {
                    case 2:
                        Console.WriteLine("inserte el titulo del videojuego");
                        videojuego.Titulo = Console.ReadLine();
                        Console.WriteLine("inserte el precio del videojuego");
                        videojuego.Precio = Console.ReadLine();
                        Console.WriteLine("inserte el genero del videojuego");
                        videojuego.Genero = Console.ReadLine();
                        Console.WriteLine("inserte la plataforma del videojuego");
                        videojuego.Plataforma = Console.ReadLine();
                        matriz.InsertarElementoArreglo(videojuego);
                        break;
                    case 3:
                        Console.WriteLine("inserte el titulo del videojuego");
                        videojuego.Titulo = Console.ReadLine();
                        Console.WriteLine("inserte el precio del videojuego");
                        videojuego.Precio = Console.ReadLine();
                        Console.WriteLine("inserte el genero del videojuego");
                        videojuego.Genero = Console.ReadLine();
                        Console.WriteLine("inserte la plataforma del videojuego");
                        videojuego.Plataforma = Console.ReadLine();
                        matriz.InsertarMedio(videojuego);
                        break;
                    case 4:
                        Console.WriteLine("inserte el elemento que quiere obtener");
                        videojuego.Titulo = Console.ReadLine();
                        matriz.ObtenerElemento(videojuego);
                        break;
                    case 5:
                        matriz.ObtenerTodosElementos();
                        break;
                    case 6:
                        matriz.Longitud();
                        break;
                    case 7:
                        matriz.Eliminar();
                        break;
                }
                Console.WriteLine("seleccione otra opcion");
                opcion = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
