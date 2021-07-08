using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejersicio24Vercion02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el primer número:");
                var numeroUno = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el segundo número:");
                var numeroDos = Convert.ToInt32(Console.ReadLine());
                if (numeroUno > numeroDos)
                {
                    Console.WriteLine((numeroUno % numeroDos == 0) ?
                        $"{numeroUno} es múltiplo de {numeroDos}" :
                        $"{numeroUno} no es múltiplo de {numeroDos}");
                }
                else if (numeroDos > numeroUno)
                {
                    Console.WriteLine((numeroDos % numeroUno == 0) ?
                        $"{numeroDos} es múltiplo de {numeroUno}" :
                        $"{numeroDos} no es múltiplo de {numeroUno}");

                }
                else
                {
                    Console.WriteLine("Ambos números son iguales");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Número mal ingresado");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Número demasiado grande para ser un entero");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
    
}
