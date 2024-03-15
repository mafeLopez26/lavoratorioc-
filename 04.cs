    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese el valor de x:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de n:");
            int n = Convert.ToInt32(Console.ReadLine());

            double resultado = Calcular(x, n);
            Console.WriteLine("El resultado de la progresión es: " + resultado);
        }
        static double Calcular(double x, int n)
        {
            double inicio = 1;

            for (int i = 1; i <= n; i++)
            {
                inicio += Math.Pow(x, i);
            }

            return inicio;
        }
    }