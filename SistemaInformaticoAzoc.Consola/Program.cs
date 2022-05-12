using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaInformaticoAzoc.Servicios;

namespace SistemaInformaticoAzoc.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejecutar();
        }

        private async static void Ejecutar()
        {
            var service = new UsuarioService();
            Modelos.Usuario result = await service.GetByIdAsync("625ee2194662cde3e39861db");
            Console.WriteLine(result.Nombre);
            //Console.WriteLine();
            //var results = service.GetAllBsonDocuments();
            //foreach (var item in results)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
