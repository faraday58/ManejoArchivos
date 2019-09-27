using System;
using System.IO;

namespace ManejoArchivos
{
    class Program
    {
        static void Main()
        {
            StreamWriter sw = null;
            FileStream fs = null;
            try
            {
                fs = new FileStream("texto1.txt", FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);
                Console.WriteLine("Escribe las líneas que desees y termina de escribir" +
                    " con dos Enter ");
                string cadena = Console.ReadLine();
                while (cadena.Length != 0)
                {

                    sw.WriteLine(cadena);
                    cadena = Console.ReadLine();
                }


            }
            catch (IOException error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {

                sw.Close();
                fs.Close();
            }

            StreamReader sr = null;
            try
            {
                fs = new FileStream("texto1.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                Console.WriteLine("*****************Mostrando contenido de archivo************** ");
                string cadena = sr.ReadLine();
                Console.WriteLine(cadena);
                while( cadena != null )
                {
                    cadena = sr.ReadLine();
                    Console.WriteLine(cadena);
                }
            }
            catch(IOException error)
            {
                Console.WriteLine(error.Message);

            }
            finally
            {
                sr.Close();
                fs.Close();
            }

        }
    }
}
