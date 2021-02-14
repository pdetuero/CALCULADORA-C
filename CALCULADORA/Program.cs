//PABLO DE TUERO HERRERO
using System;

namespace CALCULADORA
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //declaracion de variables
                decimal num1 = 0, num2 = 0, resultado = 0, n = 1;
                char opcion = '0';
                string valorElegido = "";

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("----------------Bienvenido a la supercalculadora----------------" + "\n" + "\n"
                    + "¿Desea realizar alguna operación? <S/N>");
                    valorElegido = Console.ReadLine();
                    if (valorElegido.ToUpper() == "S")
                    {
                        Peticion(opcion, num1, num2, resultado);
                        n++;
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else if (valorElegido.ToUpper() == "N")
                    {
                        Console.WriteLine("Pulse cualquier tecla para salir de la calculadora");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("La opción marcada no es válida.");
                        Console.Clear();
                        n++;
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Ha habido un problema en la aplicación. Contacte con soporte " + ex.Message);
                Console.ReadKey();
            }
        }
        //DESARROLLO DE LA CALCULADORA
        public static void Peticion(char opcion, decimal num1, decimal num2, decimal resultado)
        {
            Console.WriteLine("\n" + "Escribe un número:");
            num1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Elija una operación: + - / * ");
            opcion = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Escribe otro número:");
            num2 = Convert.ToDecimal(Console.ReadLine());
            if (opcion == '/' && num2 == 0)
            {
                throw new ArgumentException("No se puede dividir por 0");
            }

            switch (opcion)
            {
                case '+':
                    resultado = num1 + num2;
                    Console.WriteLine("El resultado de la suma es: " + resultado);
                    break;
                case '-':
                    resultado = num1 - num2;
                    Console.WriteLine("El resultado de la resta es: " + resultado);
                    break;
                case '*':
                    resultado = num1 * num2;
                    Console.WriteLine("El resultado de la multiplicación es: " + resultado);
                    break;
                case '/':
                        resultado = num1 / num2;
                        Console.WriteLine("El resultado de la división es: " + resultado);
                    break;
                default:
                    Console.WriteLine("La opción elegida no es válida, vuelva a empezar.");
                    break;
            }
        }
    }
}
