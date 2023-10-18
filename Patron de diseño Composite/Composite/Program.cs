using Patron_de_diseño_Composite.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISistemaComponente archivo1 = new Archivo("Documento.txt", 10);
            ISistemaComponente archivo2 = new Archivo("imagen.png", 15);
            ISistemaComponente archivo3 = new Archivo("word.docs", 5);
            ISistemaComponente archivo4 = new Archivo("imagen.Jpg", 25);
            ISistemaComponente archivo5 = new Archivo("trabajo practico.pdf", 20);
            ISistemaComponente archivo6 = new Archivo("trabajopractico2.txt", 20);
            ISistemaComponente archivo7 = new Archivo("imagen.bmp", 10);

            Directorio directorio1 = new Directorio("Caperta imagenes");
            directorio1.AgregarComponente(archivo2);
            directorio1.AgregarComponente(archivo4);
            directorio1.AgregarComponente(archivo7);
            Directorio directorio2 = new Directorio("Carpeta de archivos");
            directorio2.AgregarComponente(archivo1);
            directorio2.AgregarComponente(archivo3);
            directorio2.AgregarComponente(archivo5);
            directorio2.AgregarComponente(archivo6);



            int totalDirectorio1 = directorio1.Tamanio();
            int totalDirectorio2 = directorio2.Tamanio();
            Console.WriteLine($"En el directorio 1 el total es bytes es {totalDirectorio1}");
            Console.WriteLine($"En el directorio 2 el total es bytes es {totalDirectorio2}");
            Console.ReadKey();
        }
    }
}
