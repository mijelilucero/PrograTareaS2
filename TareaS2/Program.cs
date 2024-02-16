Console.WriteLine("Ingrese un texto corto: ");
string cadena = Console.ReadLine();

char[] caracteres = cadena.ToCharArray();
Array.Reverse(caracteres);
string resultado = new string(caracteres);

Console.WriteLine("La cadena invertida es: "+ resultado);