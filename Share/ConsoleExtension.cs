namespace Share;

public static class ConsoleExtension //se utiliza apra instanciar sin tener que llamar
{
    //creamos un metodo el cual podremos utilizar en cual quier momento con las respectivas validaciones
    public static int GetInt(string message)
    {
        Console.Write(message);
        var numberString= Console.ReadLine();
        if(int.TryParse(numberString, out int numberInt))
        {
            return numberInt;
        }
        return 0;  
    }

    public static string? GetValidOptions(string message, List<string>options)//public static string? la ? es para validar nulidad
    {
        Console.Write(message);
        var answer = Console.ReadLine();
        if(options.Any(x => x.Equals(answer,StringComparison.CurrentCultureIgnoreCase)))// funcion any para validar si la respuesta del usuario es igual a alguna de las opciones que tenemos en la lista, el string comparison es para validar que no importe si el usuario escribe mayuscula o minuscula
        {
            return answer;

        }
        
            return null;

         }
    public static String? GetString(string message)// el signo de interrogacion es apra confirmar que peuden ingresar valores nulos
    {
        Console.Write(message);
        var text = Console.ReadLine();
        return text;
    }

    public static float GetFloat(string message)
    {
        Console.Write(message);
        var numberString = Console.ReadLine();
          if (float.TryParse(numberString, out float    numberFloat))
        {
            return numberFloat;
        }
        return 0;
    }

    public static decimal GetDecimal(string message)
    {
        Console.Write(message);
        var numberString = Console.ReadLine();
        if (decimal.TryParse(numberString, out decimal numberDecimal))
        {
            return numberDecimal;
        }
        return 0;
    }


}
