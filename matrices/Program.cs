using matrices.Clases;
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

            Matriz matriz = new Matriz(longitud);
            matriz.InsertarElementoArreglo();
            matriz.InsertarElementoArreglo();
            matriz.InsertarElementoArreglo();
            matriz.InsertarElementoArreglo();
            matriz.InsertarElementoArreglo();
            matriz.ObtenerTodosElementos();
            matriz.ObtenerElemento();
            matriz.Longitud();
            matriz.Eliminar();
        }
    }
}
