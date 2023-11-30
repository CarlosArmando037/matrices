using matrices.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrices.Clases
{
    public class Matriz
    {
        int longitud = 0;
        int cantidadReal =0;
        VideoJuegoModel[] arreglo;

        // contructutor de con argumento opcional longitud

        public Matriz(int longitud)
        {
            arreglo = new VideoJuegoModel[longitud]; 
        }


        //metodos

        public void InsertarElementoArreglo()
        {
            Console.WriteLine("inserte el nombre del juego");
            arreglo[longitud].Titulo = Console.ReadLine();
            Console.WriteLine("inserte el precio del juego");
            arreglo[longitud].Precio = Console.ReadLine();
            Console.WriteLine("inserte el genero del juego");
            arreglo[longitud].Genero = Console.ReadLine();
            Console.WriteLine("inserte el plataforma del juego");
            arreglo[longitud].Plataforma = Console.ReadLine();
        }
        public void InsertarMedio()
        {
            int medio = 0;
            medio = arreglo.Length / 2;
            Console.WriteLine("inserte el numero de en medio");
            for (int i =0; i< arreglo.Length;i++)
            {
                if (i == medio )
                {
                    Console.WriteLine("inserte el nombre del arreglo");
                    arreglo[longitud].Titulo = Console.ReadLine();
                    Console.WriteLine("inserte el nombre del arreglo");
                    arreglo[longitud].Precio = Console.ReadLine();
                    Console.WriteLine("inserte el nombre del arreglo");
                    arreglo[longitud].Genero = Console.ReadLine();
                    Console.WriteLine("inserte el nombre del arreglo");
                    arreglo[longitud].Plataforma = Console.ReadLine();
                }
            }
        }
        public bool EsVacio()
        {
            if (longitud == 0)
            {
                return true;
            }
            return false;
        }
        public bool EstaLleno()
        {
            if (longitud == arreglo.Length)
            {
                return true;
            }
            return false;
        }
        public int Longitud()
        {
            return arreglo.Length;
        }

        // para eliminar necesitas seleccionar a minimop uno, entonces tenddre que hcaer primero otro
        public void Eliminar()
        {
            Console.WriteLine("inserte el elemento que quiere eliminar:");
            string elemento = Console.ReadLine();
            while (elemento != arreglo[longitud].Titulo)
            {
                longitud++;
            }
            arreglo[longitud].Titulo = "";
            arreglo[longitud].Precio = "";
            arreglo[longitud].Genero = "";
            arreglo[longitud].Plataforma = "";

        }

        /*
        public void OrdenarAsc()
        {
            for (int i =0 ;i < arreglo.Length;i++)
            {
                if (arreglo[i] <arreglo)
                {

                }
            }
        }
        */

        public string ObtenerElemento()
        {
            Console.WriteLine("inserte el elemento que quiere:");
            string obtener = Console.ReadLine();
            if (EsVacio())
            {
                return "la matriz esta vacia";
            }
            else
            {
                while (obtener != arreglo[longitud].Titulo)
                {
                    longitud++;
                }

                return $"{arreglo[longitud].Titulo}";
                //for(string i= obtener;obtener == arreglo[longitud].Titulo; i++ )
            }
        }
        public void ObtenerTodosElementos()
        {
            for (int j = 0; j < arreglo.Length; j++)
            {
                Console.WriteLine($"el juego se llama: {arreglo[longitud].Titulo}, cuesta: {arreglo[longitud].Precio}, de genero: {arreglo[longitud].Genero}, y plataforma: {arreglo[longitud].Plataforma}");
            }
        } 
        public void Modificar()
        {
            Console.WriteLine("inserte el elemento que quiere Modificar:");
            string elemento = Console.ReadLine();
            while (elemento != arreglo[longitud].Titulo)
            {
                longitud++;
            }
            Console.WriteLine("inserte los nuevos datos");

            Console.WriteLine("inserte el nombre del arreglo");
            arreglo[longitud].Titulo = Console.ReadLine();
            Console.WriteLine("inserte el nombre del arreglo");
            arreglo[longitud].Precio = Console.ReadLine();
            Console.WriteLine("inserte el nombre del arreglo");
            arreglo[longitud].Genero = Console.ReadLine();
            Console.WriteLine("inserte el nombre del arreglo");
            arreglo[longitud].Plataforma = Console.ReadLine();
        }


    }
}
