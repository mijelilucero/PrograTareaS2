Console.WriteLine("Ingrese el decimal 1: ");
decimal num1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Ingrese el decimal 2: ");
decimal num2 = Convert.ToDecimal(Console.ReadLine());

decimal resultado = num1 - num2;
Console.WriteLine("La resta de {0} menos {1} es: {2}", num1, num2, resultado);
