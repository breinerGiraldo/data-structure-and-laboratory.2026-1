
using Share;

var answer = string.Empty;
var options = new List<string> { "s", "n" };// definimos una lista de opciones para validar la respuesta del usuario


var credits= ConsoleExtension.GetInt("Ingrese el numero de creditos a matricular: ");
var Val_credit = ConsoleExtension.GetDecimal("Ingrese el valor por credito: ");
var Stud_Stra = ConsoleExtension.GetInt("Ingrese el estrato socioeconomico del estudiante: ");











do
{
    answer = ConsoleExtension.GetValidOptions("Desea continuar [S]i , [N]o?: ", options);
} while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));// validamos que la respuesta del usuario sea igual a alguna de las opciones que tenemos en la lista, el string comparison es para validar que no importe si el usuario escribe mayuscula o minuscula 

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase)) ;
Console.WriteLine("F mi loco");