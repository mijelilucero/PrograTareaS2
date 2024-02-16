Console.WriteLine("Ingrese un valor para la altura: ");
decimal h = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Ingrese un valor para la base: ");
decimal b = Convert.ToDecimal(Console.ReadLine());

decimal area = (b * h) / 2;

Console.WriteLine("El area del triangulo es de: {0}", area);