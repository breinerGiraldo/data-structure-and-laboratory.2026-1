// See https://aka.ms/new-console-template for more information


using Share;// con este utilizamos la libreria que creamos en Share

var answer = string.Empty;
var options = new List<string> { "s", "n" };// definimos una lista de opciones para validar la respuesta del usuario
do
{
    var number = ConsoleExtension.GetInt("Ingrese Numero entero o ctr c para salir :"); //ya solo llamamos la funcion que creamos en la libreria se ahorra la verificacion del punto pasado



        if (number % 2 == 0)
        {
            Console.WriteLine($"el numero {number} es par.");
        }
        else
        {
            Console.WriteLine($"El numero {number} es Impar.");
        }
    do
    {
        answer = ConsoleExtension.GetValidOptions("Desea continuar [S]i , [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));// validamos que la respuesta del usuario sea igual a alguna de las opciones que tenemos en la lista, el string comparison es para validar que no importe si el usuario escribe mayuscula o minuscula 

} while (answer!.Equals("s",StringComparison.CurrentCultureIgnoreCase) );
Console.WriteLine("F mi loco");