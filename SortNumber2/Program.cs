using Share;// con este utilizamos la libreria que creamos en Share
var answer = string.Empty;
var options = new List<string> { "s", "n" };// definimos una lista de opciones para validar la respuesta del usuario
do
{
    var a = ConsoleExtension.GetInt("Ingrese el primer numero: ");
    var b = ConsoleExtension.GetInt("Ingrese el segundo numero: ");
    var c = ConsoleExtension.GetInt("Ingrese el tercer numero: ");

    if (a > b)
    {
        if (b < c)
        {
            Console.WriteLine($"El mayor es{a}, el medio es {b} le menor es {c}");
        }
        else {

            Console.WriteLine($"El mayor es{a}, el medio es {c} le menor es {b}");

        }


    }
    else if (b > a && b > c)
    
    {
        if (a > c)
        {
            Console.WriteLine($"El mayor es{b}, el medio es {a} le menor es {c}");
        }
        else 
        {
            Console.WriteLine($"El mayor es{b}, el medio es {c} le menor es {a}");

        }
        

    }


}  
do
{
    answer = ConsoleExtension.GetValidOptions("Desea continuar [S]i , [N]o?: ", options);
} while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));// validamos que la respuesta del usuario sea igual a alguna de las opciones que tenemos en la lista, el string comparison es para validar que no importe si el usuario escribe mayuscula o minuscula 

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase)) ;
Console.WriteLine("F mi loco");