using Share;// con este utilizamos la libreria que creamos en Share
var answer = string.Empty;
var options = new List<string> { "s", "n" };// definimos una lista de opciones para validar la respuesta del usuario

do
{
    var a = ConsoleExtension.GetInt("Ingrese el primer numero: ");
    var b = ConsoleExtension.GetInt("Ingrese el segundo numero: ");
    var c = ConsoleExtension.GetInt("Ingrese el tercer numero: ");

    if (a > b && a > c)
    {
        if (b > c)
        {
            Console.WriteLine($"El mayor es {a} el de el emdio es {b} el emenor es {c}");

        }
        else
        {
            Console.WriteLine($"El mayor es {a}, el de el medio es {c} el menor es {b}");
        }
    }
    else if (b > a && b > c)
    {
        if (a > c)
        {
            Console.WriteLine($"El mayor es {b} el de el medio es {a} el emenor es {c}");
        }
        else
        {
            Console.WriteLine($"El mayor es {b}, el de el medio es {c} el menor es {a}");
        }
    }
    else
    {
        if (a > b)
        {
            Console.WriteLine($"El mayor es {c} el de el medio es {a} el emenor es {b}");
        }
        else
        {
            Console.WriteLine($"El mayor es {c}, el de el medio es {b} el menor es {a}");
        }
    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("Desea continuar [S]i , [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));// validamos que la respuesta del usuario sea igual a alguna de las opciones que tenemos en la lista, el string comparison es para validar que no importe si el usuario escribe mayuscula o minuscula 

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("F mi loco");