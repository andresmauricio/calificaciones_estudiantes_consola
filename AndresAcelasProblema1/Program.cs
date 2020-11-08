using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndresAcelasProblema1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("::: ANDRÉS MAURICIO ACELAS AREVALO :::");
            Console.WriteLine("::: COD -> 1052412239 :::");
            Console.WriteLine();
            Console.WriteLine();


            do
            {
                Console.WriteLine();
                Console.Write("Ingrese la nota del estudiante: ");
                var value = Console.ReadLine();
                var Nota = float.Parse(value, CultureInfo.InvariantCulture.NumberFormat);
                Console.WriteLine(Nota);

                if (Nota >= 4.8 && Nota <= 5.0)
                {
                    Console.WriteLine("La calificación del estudiante es: Excelente");
                }
                else if (Nota >= 4.0 && Nota <= 4.7)
                {
                    Console.WriteLine("La calificación del estudiante es: Bueno");
                }
                else if (Nota >= 3.0 && Nota <= 3.9)
                {
                    Console.WriteLine("La calificación del estudiante es: Regular");
                }
                else if (Nota <= 2.9)
                {
                    Console.WriteLine("La calificación del estudiante es: Descuidado");
                }
                else
                {
                    Console.WriteLine("La calificaón ingresada no es válida");
                }

                Console.WriteLine("--------------------");


            } while (true);

            Console.ReadLine();

        }

        public void VerificarEvaluacionConFor()
        {
            Console.WriteLine("Ingrese la cantidad de estudiantes: ");
            var NumeroDeEstudiante = Console.ReadLine();

            Console.WriteLine("Ingrese la nota del estudiante: ");
            var value = Console.ReadLine();
            var Nota = Double.Parse(value);

            for (int i = 0; i < NumeroDeEstudiante.Length; i++)
            {

                if (Nota >= 4.8)
                {
                    Console.WriteLine("La calificación del estudiante es: Excelente");
                }
                else if (Nota >= 4.0 && Nota <= 4.7)
                {
                    Console.WriteLine("La calificación del estudiante es: Bueno");
                }
                else if (Nota >= 3.0 && Nota <= 3.9)
                {
                    Console.WriteLine("La calificación del estudiante es: Regular");
                }
                else if (Nota <= 2.9)
                {
                    Console.WriteLine("La calificación del estudiante es: Descuidado");
                }

            }

            Console.ReadLine();

        }
    }
}
