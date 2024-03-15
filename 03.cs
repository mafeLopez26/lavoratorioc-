    class Program
    {
        static void Main()
        {
            double radio, angulo, coordenadaX, coordenadaY;

            (radio, angulo) = SolicitarCoordenadasPolares();
            (coordenadaX, coordenadaY) = ConvertirCoordenadasPolaresARectangulares(radio, angulo);
            MostrarCoordenadasRectangulares(coordenadaX, coordenadaY);
        }

        static (double, double) ConvertirCoordenadasPolaresARectangulares(double radio, double anguloEnGrados)
        {
            double anguloEnRadianes = Math.PI * anguloEnGrados / 180;

            double coordenadaX = radio * Math.Cos(anguloEnRadianes);
            double coordenadaY = radio * Math.Sin(anguloEnRadianes);

            return (coordenadaX, coordenadaY);
        }

        static (double, double) SolicitarCoordenadasPolares()
        {
            Console.Write("Ingrese el valor del radio: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el valor del ángulo en grados: ");
            double angulo = Convert.ToDouble(Console.ReadLine());

            return (radio, angulo);
        }

        static void MostrarCoordenadasRectangulares(double coordenadaX, double coordenadaY)
        {
            Console.WriteLine("Coordenadas rectangulares:");
            Console.WriteLine($"x = {coordenadaX}");
            Console.WriteLine($"y = {coordenadaY}");
        }
    }
