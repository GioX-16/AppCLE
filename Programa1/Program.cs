using System;
using System.IO;

namespace Programa1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creacion del archivo // 
            TextWriter archivo = new StreamWriter("C:/Users/USUARIO/Desktop/GIO archivo.txt");
            Console.WriteLine(" Ingrese el Texto que quiere escribir \n ");
            string texto = Console.ReadLine().ToString();
            archivo.WriteLine(texto);
            archivo.Close();

            // LEER ARCHIVOS  // 

            TextReader leer_archivo = new StreamReader("C:/Users/USUARIO/Desktop/GIO archivo.txt");
            Console.WriteLine(leer_archivo.ReadLine());
            leer_archivo.Close();

            Console.WriteLine("<===================================================> \n");

            // insertar texto en archivo  // 

            TextWriter archivo2 = File.AppendText("C:/Users/USUARIO/Desktop/GIO archivo.txt");
            Console.WriteLine(" Ingrese el Texto que quiere escribir \n ");
            string texto2 = Console.ReadLine().ToString();
            archivo2.WriteLine(texto2);
            archivo2.Close();

        }
    }
}
