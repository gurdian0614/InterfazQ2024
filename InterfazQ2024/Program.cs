
// Variables para validar el ingreso de los datos
using InterfazQ2024;

string? strN1, strN2;

//Objeto
Operacion operacion = new Operacion();
Console.WriteLine("Ingrese primer número");
strN1 = Console.ReadLine();
Console.WriteLine("Ingrese segundo número");
strN2 = Console.ReadLine();

// Validar espacios en blanco
if (strN1 is null || strN1 == "")
{
    Console.WriteLine("Debe ingresar primer número");
} else if (strN2 is null || strN2 == "")
{
    Console.WriteLine("Debe ingresar segundo número");
} else
{
    bool validN1, validN2;

    validN1 = double.TryParse(strN1, out operacion.N1);
    validN2 = double.TryParse(strN2, out operacion.N2);

    // Validar el formato correcto
    if (!validN1)
    {
        Console.WriteLine("Primer número no válido, favor ingresar en formato numérico");

    } else if (!validN2)
    {
        Console.WriteLine("Segundo número no válido, favor ingresar en formato numérico");
    }
    else
    {
        if (operacion.N2 != 0)
        {
            operacion.Imprimir();
        }
        else
        {
            Console.WriteLine("Segundo número no puede ser cero");
        }
    }
}