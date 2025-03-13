using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiasDeLaSemana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //validar el día de la semana correspondiente al número ingresado
            //Tabata Vernaza
            int dia;
            do
            {
                Console.Write("Ingresa un número entre 1 y 7 para saber el día al que corresponde: ");
                dia = int.Parse(Console.ReadLine());

                switch (dia)
                {
                    case 1:
                        Console.WriteLine("Lunes");
                        break;
                    case 2:
                        Console.WriteLine("Martes");
                        break;
                    case 3:
                        Console.WriteLine("Miércoles");
                        break;
                    case 4:
                        Console.WriteLine("Jueves");
                        break;
                    case 5:
                        Console.WriteLine("Viernes");
                        break;
                    case 6:
                        Console.WriteLine("Sábado");
                        break;
                    case 7:
                        Console.WriteLine("Domingo");
                        break;
                    default:
                        Console.WriteLine("Número fuera de rango");
                        break;

                } while (true);
            } while (dia != 0);
        }
    }
}
