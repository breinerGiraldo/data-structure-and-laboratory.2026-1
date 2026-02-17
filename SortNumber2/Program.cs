using Share;// con este utilizamos la libreria que creamos en Share
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


} while (true);