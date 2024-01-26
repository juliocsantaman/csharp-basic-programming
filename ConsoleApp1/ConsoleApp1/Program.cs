// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Calculate area from a rectangular form.
float sideA = 0f, sideB = 0f, area = 0f;
bool operatorXor = true ^ false;
//bool operatorXor = true ^ false ^ true;

try
{
    Console.Write("Ingresa lado A: ");
    sideA = float.Parse(Console.ReadLine());

    Console.Write("Ingresa lado B: ");
    sideB = float.Parse(Console.ReadLine());

    area = sideA * sideB;

    Console.WriteLine("Valor de lado A: " + sideA);
    Console.WriteLine("Valor de lado B: " + sideB);
    Console.WriteLine("Área del rectangulo es: " + area);

    Console.WriteLine("Operator Xor: " + operatorXor);
}
catch (FormatException)
{
    Console.WriteLine("Error: No ingresaste un número válido. Por favor, ingresa un número decimal.");

}
catch (Exception ex)
{

    Console.WriteLine("Ocurrió un error inesperado: " + ex.Message);

}