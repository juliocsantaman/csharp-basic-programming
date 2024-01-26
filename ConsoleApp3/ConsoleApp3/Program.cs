// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int counter = 0;
int[] numbers;
bool error = false;

do
{
    try
    {
        Console.Write("Cantidad de números a ingresar: ");
        counter = int.Parse(Console.ReadLine());
        Console.WriteLine();

        numbers = new int[counter];


        for (int i = 0; i < numbers.Length; i++)
        {

            Console.Write($"Ingresa número {i + 1}: ");
            int temporaryNumber = int.Parse(Console.ReadLine());

            if (temporaryNumber >= 1 && temporaryNumber <= 10)
            {
                numbers[i] = temporaryNumber;
                error = false;

            }
            else
            {
                Console.Error.WriteLine("Error: Ingresa un número en el rango de 1 a 10. \n");
                error = true; break;

            }


        }

        if(!error)
        {
            Console.WriteLine("\nLista de números");

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }



    }
    catch (FormatException ex)
    {
        Console.Error.WriteLine($"Error: {ex.Message}\n");
        error = true;
    }
    catch (Exception ex)
    {
        Console.Error.WriteLine($"Error: {ex.Message}\n");
        error = true;
    }

} while (error);
