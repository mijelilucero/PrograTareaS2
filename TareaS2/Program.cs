Console.WriteLine("Ingrese un texto corto: ");
string cadena = Console.ReadLine();

Console.WriteLine("Ingrese la palabra a buscar: ");
string palabra = Console.ReadLine();

if (cadena.ToLower().Contains(palabra.ToLower()))
{
    Console.WriteLine("La cadena si tiene la palabra {0}.", palabra);
}
else
{
    Console.WriteLine("La cadena no tiene la palabra {0}.", palabra);
}