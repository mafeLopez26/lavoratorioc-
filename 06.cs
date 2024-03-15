    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GRAFICAS DE FRACCIONES\n");
            Console.WriteLine("Ingresa el limite: \n");
            int limite = Convert.ToInt32(Console.ReadLine());
            GraficarFracciones(limite);
        }

        static void GraficarFracciones(int limite)
        {
            for (int i = 0; i < limite; i++)
            {
                Console.Write($"{i + 1}\t");
            }
            Console.WriteLine("\n");

            for (int i = 0; i < limite; i++)
            {
                Console.Write("--\t");
            }
            Console.WriteLine("\n");

            for (int i = 0; i < limite; i++)
            {
                Console.Write("2^" + (i + 1) + "\t");
            }
            Console.WriteLine();
        }
    }
}