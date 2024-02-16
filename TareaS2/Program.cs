Console.WriteLine("Ingrese el valor en X del primer punto: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el valor en Y del primer punto: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el valor en X del segundo punto: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el valor en Y del segundo punto: ");
double y2 = Convert.ToDouble(Console.ReadLine());

double distancia = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

Console.WriteLine("La distancia entre los dos puntos es de: {0}", distancia);