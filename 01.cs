internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese su año de nacimiento:");
        int Nacimiento = int.Parse(Console.ReadLine());
        int Edad = CalcularEdad(Nacimiento);

        Console.WriteLine("Tiene: " + Edad + " Años");
    }
    static int CalcularEdad(int Nacimiento)
    {
        int añoActual = 2024;
        int edad = añoActual - Nacimiento;
        return edad;
    }
}