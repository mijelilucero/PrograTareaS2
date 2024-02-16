Console.WriteLine("Ingrese la temperatura en grados Celsius: ");
double celsius = Convert.ToDouble(Console.ReadLine());

double fahrenheit = (celsius * 1.8) + 32;

Console.WriteLine("La temperatura en grados Fahrenheit es de: {0}", fahrenheit);