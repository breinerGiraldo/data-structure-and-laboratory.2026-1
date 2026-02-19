using Share;// con este utilizamos la libreria que creamos en Share

var answer = string.Empty;
var options = new List<string> { "s", "n" };// definimos una lista de opciones para validar la respuesta del usuario
do
{
    Console.WriteLine("Ingrese 3 numeros enteros para comparar cual es el mayor");
    var number1 = ConsoleExtension.GetInt("Ingrese Primer numero:"); //ya solo llamamos la funcion que creamos en la libreria se ahorra la verificacion del punto pasado
    var number2 = ConsoleExtension.GetInt("Ingrese segundo numero:");
    var number3= ConsoleExtension.GetInt("Ingrese tercer numero:");

    if (number1 > number2 && number1 > number3) 
    {
           Console.WriteLine($"el numero {number1} es el mayor.");
    }
    else if (number2 > number1 && number2 > number3) 
    {
        Console.WriteLine($"el numero {number2} es el  mayor.");
    }
    else if(number3 >  number1 && number3> number2 )
    {
        Console.WriteLine($"el numero {number3} es el mayor..");
    }



    do
    {
        answer = ConsoleExtension.GetValidOptions("Desea continuar [S]i , [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));// validamos que la respuesta del usuario sea igual a alguna de las opciones que tenemos en la lista, el string comparison es para validar que no importe si el usuario escribe mayuscula o minuscula 

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("F mi loco");