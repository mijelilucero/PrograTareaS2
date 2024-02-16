Console.WriteLine("Ingrese un valor de tipo float: ");

float numFloat;

if (float.TryParse(Console.ReadLine(), out numFloat))
{
    int numInt = Convert.ToInt32(numFloat);
    Console.WriteLine("El valor float ingresado convertido a entero es: " + numInt);
}
