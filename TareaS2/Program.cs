Console.WriteLine("Ingrese un valor para el radio: ");
double radio = Convert.ToDouble(Console.ReadLine());

const double Pi = 3.14159;

double volumen = (4*Pi)*(radio*radio*radio)/3;

Console.WriteLine("El volumen de la esfera es de: {0}", volumen);