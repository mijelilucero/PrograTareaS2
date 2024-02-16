Console.WriteLine("Ingrese la temperatura en grados Fahrenheit: ");
double fahrenheit = Convert.ToDouble(Console.ReadLine());

double celsius = (fahrenheit - 32) / 1.8;

Console.WriteLine("La temperatura en grados Celsius es de: {0}", celsius);