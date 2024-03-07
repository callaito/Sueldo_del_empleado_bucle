// See https://aka.ms/new-console-template for more information
Console.WriteLine("Imprimir numeros en pantalla del 1 al 10");
Console.WriteLine();

for(int i = 1; i<= 10; i++)

{
    Console.WriteLine("Numero - " + i);
}

Console.WriteLine();
//Declarar siempre primero

double sueldo, total, promedio;

//Inicializar siempre antes del bucle
total = 0;

for(int i = 1; i <= 3; i++)
{

    Console.WriteLine("Sueldo del empleado " + i);
    sueldo = Convert.ToDouble(Console.ReadLine());
    total += sueldo;
}

//Calcular el promedio
promedio = total / 3;

Console.WriteLine("El sueldo promedio de um empleado es: " + promedio);

