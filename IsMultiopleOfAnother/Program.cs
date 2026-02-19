using Share;
var answer = string.Empty;
var options = new List<string> { "s", "n" };// definimos una lista de opciones para validar la respuesta del usuario
do { 
var a = ConsoleExtension.GetInt("Ingrese el primer numero: ");
var b = ConsoleExtension.GetInt("Ingrese el segundo numero: ");
    if (b % a == 0)
    {
        Console.WriteLine($"{a} es multiplo de {b}");
    }
    else
    {
        Console.WriteLine($"{a} no  es multiplo de {b}");

    }

    do
{
    answer = ConsoleExtension.GetValidOptions("Desea continuar [S]i , [N]o?: ", options);
} while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));// validamos que la respuesta del usuario sea igual a alguna de las opciones que tenemos en la lista, el string comparison es para validar que no importe si el usuario escribe mayuscula o minuscula 

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase)) ;
Console.WriteLine("F mi loco");