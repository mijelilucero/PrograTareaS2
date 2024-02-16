Console.WriteLine("Ingrese un texto corto: ");
string cadena = Console.ReadLine().ToLower();

int conteo = 0;

for (int i = 0; i < cadena.Length; i++)
{
    if (cadena[i] == 'a'|| cadena[i] == 'e' || cadena[i] == 'i' || cadena[i] == 'o' || cadena[i] == 'u')
    {
        conteo++;
    }
}

Console.WriteLine("La cantidad de vocales en la palabra es de: {0}", conteo);