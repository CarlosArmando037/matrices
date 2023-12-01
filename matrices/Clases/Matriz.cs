﻿using matrices.Modelo;
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
        public void Eliminar()
        {
            //Console.WriteLine("inserte el elemento que quiere eliminar:");
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