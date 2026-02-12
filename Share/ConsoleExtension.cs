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

}
