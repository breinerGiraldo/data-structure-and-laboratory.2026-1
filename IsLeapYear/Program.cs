using Share;
do
{
    var currentYear = DateTime.Now.Year;//creamos una variable para guardar el año actual del sistema
    var message= string.Empty;
    var year = ConsoleExtension.GetInt("Ingrese ano: ");

    //hacemos uan validacion mejor organiozada por la varible nmessage
    if (year == currentYear) 
    {
        message= "es"
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

  

} while (true);