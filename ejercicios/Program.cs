//static void saludar(String nomsal)
//{
//    Console.WriteLine($"un gran saludo a " + nomsal);
//}

//static int año_nacimiento(int edad)
//{
//    int año = 2023 - edad;
//    return año;
//}


//String nombre;
//int edad;
//int año_nac;
//Console.WriteLine("Cómo te llamas?");
//nombre = Console.ReadLine();
//saludar(nombre);


//Console.WriteLine($"Hola, gusto de saludarte " + nombre);
//Console.WriteLine("Cuantos años tienes?");
//edad = Convert.ToInt32(Console.ReadLine());
//año_nac = año_nacimiento(edad);
//Console.WriteLine($"Bonita edad: " + edad);
//Console.WriteLine("Naciste en " + año_nac);

static bool palindromo(String palabra)
{
    int longitud = palabra.Length;

    string pal = "";
    for (int c = longitud - 1; c >= 0; c--)
    {
        pal = pal + palabra[c].ToString();
    }

    if (palabra.Equals(pal))
    {
        return true;
    }
    else
    {
        return false;
    }


}

String palabra;
palabra = "maria";
bool espalindromo = palindromo("ana".ToUpper();

if (espalindromo)
{
    Console.WriteLine("Es palindromo.");
}
else
{
    Console.WriteLine("Nel");
}