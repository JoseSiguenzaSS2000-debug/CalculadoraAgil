Console.WriteLine("=== CALCULADORA ÁGIL ===");

Console.Write("Ingrese el primer número: ");
double numero1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el segundo número: ");
double numero2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\nSeleccione una operación:");
Console.WriteLine("1. Suma");
Console.WriteLine("2. Resta");
Console.WriteLine("3. Multiplicación");
Console.WriteLine("4. División");

Console.Write("Opción: ");
int opcion = Convert.ToInt32(Console.ReadLine());

double resultado = 0;

switch (opcion)
{
    case 1:
        resultado = numero1 + numero2;
        break;

    case 2:
        resultado = numero1 - numero2;
        break;

    case 3:
        resultado = numero1 * numero2;
        break;

    case 4:
        if (numero2 != 0)
        {
            resultado = numero1 / numero2;
        }
        else
        {
            Console.WriteLine("Error: no se puede dividir entre cero.");
            return;
        }
        break;

    default:
        Console.WriteLine("Opción no válida.");
        return;
}

Console.WriteLine($"\nResultado: {resultado}");
Console.WriteLine("Gracias por usar Calculadora Agil.");