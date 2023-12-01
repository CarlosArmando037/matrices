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

        public bool InsertarElementoArreglo(VideoJuegoModel videoJuego)
        {
            if (EstaLleno())
            {
                return false;
            }
            else
            {
                arreglo[cantidadReal] = videoJuego;
                cantidadReal++;
                return true;
            }
        }
        public void InsertarMedio(VideoJuegoModel videojuego)
        {
            int medio = 0;
            medio = arreglo.Length / 2;
            for (int i =0; i< arreglo.Length;i++)
            {
                if (i == medio )
                {
                    arreglo[i] = videojuego;
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
        public void Eliminar(VideoJuegoModel videoJuego)
        {
            //Console.WriteLine("inserte el elemento que quiere eliminar:");
            for(int i =0; i < arreglo.Length;i++)
            {
                if (videoJuego.Titulo == arreglo[i].Titulo)
                {
                    arreglo[i] = null;
                    RecorrerArreglo();
                }
                cantidadReal++;
            }
        }
        public void RecorrerArreglo()
        {
            for (int i =0; i < arreglo.Length-1;i++)
            {
                for (int j = i+1 ; j<arreglo.Length ; j++)
                {
                    if (arreglo[i] == null)
                    {
                        int temp = j;
                        i = j;
                        j = temp;
                    }

                }
                
            }
        }

        
        //como puedo hacer que me ordene con string?
        /*
        public void OrdenarAsc()
        {
            for (int i =0 ;i < arreglo.Length-1;i++)
            {
                for (int j = i+1; j<arreglo.Length; j++)
                {
                    if (arreglo[j] < arreglo[i])
                    {

                    }
                }
            }
        }
        */
        

        public void ObtenerElemento(VideoJuegoModel videojuego)
        {
            if (EsVacio())
            {
                Console.WriteLine("la matriz esta vacia");
            }
            else
            {
                for (int i = 0; i < arreglo.Length; i++)
                {
                    if (arreglo[i].Titulo == videojuego.Titulo)
                    {
                        Console.WriteLine($"el juego es {arreglo[i].Titulo}, precio: {arreglo[i].Precio}, genero: {arreglo[i].Genero}, y plataforma: {arreglo[i].Plataforma}");
                    }
                    else
                    longitud++;
                } 
            }
        }
        public void ObtenerTodosElementos()
        {
            for (int j = 0; j < arreglo.Length; j++)
            {
                Console.WriteLine($"el juego se llama: {arreglo[j].Titulo}, cuesta: {arreglo[j].Precio}, de genero: {arreglo[j].Genero}, y plataforma: {arreglo[j].Plataforma}");
            }
        } 
        public void Modificar(VideoJuegoModel videojuego)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (videojuego.Titulo == arreglo[i].Titulo)
                {
                    InsertarElementoArreglo(videojuego);
                }
                longitud++;
            }
            Console.WriteLine("inserte los nuevos datos");

        }


    }
}
