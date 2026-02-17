using Share;
do { 
var a = ConsoleExtension.GetInt("Ingrese el primer numero: ");
var b = ConsoleExtension.GetInt("Ingrese el segundo numero: ");
    if (b % a == 0)
    {
        Console.WriteLine($"{a}e s multiplo de {b}");
    }
    else
    {
        Console.WriteLine($"{a}no  es multiplo de {b}");

    }

    } while (true) ;