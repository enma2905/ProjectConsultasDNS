
using System;
using System.IO; //Nueva herramienta para manejar archivos de texto
using System.Net;


namespace ConsultasDNS
{
    internal class Program
    {
        static void Main()
        {
            //Nombre de Archivo donde se guardara el historial
            string rutaArchivo = " historial_dns.txt";

            Console.WriteLine("=== CONSULTAS DNS AVANZADA ===");
            Console.WriteLine($"Los resultados se guardaran en: {rutaArchivo}\n");

            // Bucle infinito para consultar multiples veces
            while (true)
            {
                Console.Write("Ingresse un dominio (o escriba 'salir' para terminar): ");
                string dominio = Console.ReadLine() ?? "";

                // Condicion para romper el bucle y cerrar el programa 
                if (dominio.ToLower() == "salir")

                {
                    break;
                }

                if (string.IsNullOrWhiteSpace(dominio))

                {
                    Console.WriteLine("Por favor ingrese un dominio valido.\n");
                    continue;
                }

                try
                {
                    IPAddress[] direcciones = Dns.GetHostAddresses(dominio);
                    Console.WriteLine("\nDirecciones IP encontradas:");

                    // Preparamos el texto que se va escribir en el archivo
                    string registro = $"--- Consulta: {dominio} ({DateTime.Now}) ---\n";

                    foreach (IPAddress IP in direcciones)
                    {
                        Console.WriteLine($" - {IP}");
                        registro += $"{IP}\n"; // Vamos sumando las IPs al registro
                    }

                    registro += "\n";
                    // Guarda el registro en el archivo sin borrar lo que ya existia (Apped)

                    File.AppendAllText(rutaArchivo, registro);
                    Console.WriteLine("Resultados guardados con exito!\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message + '\n');
                }

                Console.WriteLine("\nPrograma finalizado. Precione una tecla para salir...");
                Console.ReadKey();

            }

        }

    }

}

        
                

