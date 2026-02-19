

using Share;

var answer = string.Empty;
var options = new List<string> { "s", "n" };// definimos una lista de opciones para validar la respuesta del usuario

do
{
    var Num_desks = ConsoleExtension.GetInt("Ingrese el numero de escritorios a comprar: ");

    var Pay_total = CalculateValue(Num_desks);
    Console.WriteLine($"El valor total a pagar es: {Pay_total:C2}");// el :C2 es para formatear el valor a moneda con 2 decimales



    do
    {
        answer = ConsoleExtension.GetValidOptions("Desea continuar [S]i , [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));// validamos que la respuesta del usuario sea igual a alguna de las opciones que tenemos en la lista, el string comparison es para validar que no importe si el usuario escribe mayuscula o minuscula 

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

decimal CalculateValue(int Num_desks)
{
    float discount = 0f;
    if (Num_desks < 5)
    {
        discount = 0.1f;
    }
    else if (Num_desks >= 10)
    {
        discount = 0.2f;
    }
    else
    {
        discount = 0.4f;
    }

    return Num_desks * 650000M * (decimal)(1 - discount);

}

Console.WriteLine("F mi loco");