    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                MostrarMenu();
                Console.Write("Elija una opción: ");
                opcion = Console.ReadLine()[0];

                switch (opcion)
                {
                    case 'a':
                        Dividir();
                        break;
                    case 'b':
                        ObtenerCubo();
                        break;
                    case 'c':
                        CalcularIMC();
                        break;
                    case 'd':
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Inténtelo de nuevo.");
                        break;
                }
            } while (opcion != 'd');
        }

        static void MostrarMenu()
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("a) Dividir");
            Console.WriteLine("b) Obtener cubo");
            Console.WriteLine("c) Cálculo de IMC (Índice de Masa Corporal)");
            Console.WriteLine("d) Salir");
        }

        static void Dividir()
        {
            Console.Write("Ingrese el dividendo: ");
            double dividendo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el divisor: ");
            double divisor = Convert.ToDouble(Console.ReadLine());

            if (divisor != 0)
            {
                double resultado = dividendo / divisor;
                Console.WriteLine($"El resultado de la división es: {resultado}");
            }
            else
            {
                Console.WriteLine("No se puede dividir por cero.");
            }
        }

        static void ObtenerCubo()
        {
            Console.Write("Ingrese un número: ");
            double numero = Convert.ToDouble(Console.ReadLine());
            double cubo = Math.Pow(numero, 3);
            Console.WriteLine($"El cubo de {numero} es: {cubo}");
        }

        static void CalcularIMC()
        {
            static void CalcularIMC()
            {
                Console.Write("Ingrese su peso en kg: ");
                double peso;
                if (double.TryParse(Console.ReadLine(), out peso))
                {
                    Console.Write("Ingrese su altura en metros: ");
                    double altura;
                    if (double.TryParse(Console.ReadLine(), out altura))
                    {
                        double imc = peso / (altura * altura);
                        Console.WriteLine($"Su Índice de Masa Corporal (IMC) es: {imc:F2}");
                    }
                    else
                    {
                        Console.WriteLine("Formato de altura incorrecto. Debe ser un número.");
                    }
                }
                else
                {
                    Console.WriteLine("Formato de peso incorrecto. Debe ser un número.");
                }
            }
        }
    }