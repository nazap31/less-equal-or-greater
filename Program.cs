int num;
Console.WriteLine("Porfavor ingrese un numero");
num = int.Parse(Console.ReadLine());

if (num == 5)
{
  Console.WriteLine("El numero ingresado es igual a 5");  
}
    else if (num > 5)
    {
      Console.WriteLine("El numero ingresado es mayor a 5");
    }
else if (num < 5)
{
  Console.WriteLine("El numero ingresado es menor a 5");
}

Console.WriteLine("Programa terminado!");