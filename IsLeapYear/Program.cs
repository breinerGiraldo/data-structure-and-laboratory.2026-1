using Share;
var answer = string.Empty;
var options = new List<string> { "s", "n" };// definimos una lista de opciones para validar la respuesta del usuario
do
{
    var currentYear = DateTime.Now.Year;//creamos una variable para guardar el año actual del sistema
    var message= string.Empty;
    var year = ConsoleExtension.GetInt("Ingrese ano: ");

    //hacemos uan validacion mejor organiozada por la varible nmessage
    if (year == currentYear) 
    {
        message = "es";
    }
    else if (year > currentYear)
    {
        message= "sera";
    }
    else
    {
        message= "fue";
    }




    if (year % 4 == 0)

    {
        if (year % 100 == 0)
        {
            if ( year % 400 ==0) 
            
            {
                Console.WriteLine($"el  {year} Si{message}biciesto");
            }
            else
            {
                Console.WriteLine($"el  {year} no{message}biciesto");
            }

        }
        else 
        {
            Console.WriteLine($"el  {year} Si{message}biciesto");
        }




    }
    else
    {
        Console.WriteLine($"el  { year} no{message}biciesto");
    }



    do
    {
        answer = ConsoleExtension.GetValidOptions("Desea continuar [S]i , [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));// validamos que la respuesta del usuario sea igual a alguna de las opciones que tenemos en la lista, el string comparison es para validar que no importe si el usuario escribe mayuscula o minuscula 

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("F mi loco");