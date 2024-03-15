    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese el límite de la serie Fibonacci:");
            int limite = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("La serie Fibonacci hasta el límite " + limite + " es:");
            for (int i = 0; i < limite; i++)
            {
                Console.Write(CalcularSerieFibonacci(i) + " ");
            }
        }

        static int CalcularSerieFibonacci(int posicion)
        {
            if (posicion <= 1)
            {
                return posicion;
            }
            else
            {
                return CalcularSerieFibonacci(posicion - 1) + CalcularSerieFibonacci(posicion - 2);
            }
        }
    }

