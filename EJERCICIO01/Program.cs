using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO01
{
    internal class Program
    {
        static int max = 100;
        static string[] nombres = new string[max];
        static double[] notas = new double[max];
        static int contador = 0;
        static public void Titulo()
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("\nSISTEMA DE GESTION DE NOTAS");
            Console.WriteLine("**********************************");
        }
        static public void Registrar_Estudiante()
        {
            Console.WriteLine("Registro de estudiante nuevo: ");
            if (contador >= 100)
            {
                Console.WriteLine("Se ha alcanzado el límite máximo.");
                return;
            }
            Console.Write("Ingrese el nombre del estudiante: ");
            string nombre = Console.ReadLine();
            double nota;
            while (true)
            {
                Console.Write("Ingrese la nota del estudiante[0-20]: ");
                nota=double.Parse(Console.ReadLine());
                if (nota >= 0 && nota <= 20)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nota inválida. Ingrese un valor entre 0 y 20.");
                    Console.Write("Ingrese la nota del estudiante: ");
                }
            }
            nombres[contador] = nombre;
            notas[contador] = nota;
            contador++;
            Console.WriteLine("Estudiante registrado correctamente.");
        }
        static public void Buscar_Estudiante()
        {

        }
        static void Main(string[] args)
        {
        }
    }
}
