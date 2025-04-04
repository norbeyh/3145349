Console.Write("Introduce un número: ");
int numero = Convert.ToInt32(Console.ReadLine());

// Comprobar si el número es par o impar
if (numero % 2 == 0)
{
    Console.WriteLine("El número {0} es par.", numero);
}
else
{
    Console.WriteLine("El número {0} es impar.", numero);
}
   
