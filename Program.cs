//Напишите программу, которая на вход принимает два числа и выдает, 
//какое число большее, какое меньшее.

Console.Write("Введите первое число => ");
string paramString1 = Console.ReadLine();
int Paramint1 = int.Parse(paramString1);
Console.Write("Введите второе число => ");
string paramString2 = Console.ReadLine();
int Paramint2 = int.Parse(paramString2);

if (Paramint1 == Paramint2)
{
    Console.WriteLine($"Результат {Paramint1}={Paramint2}");
}
else
{
    if (Paramint1 > Paramint2)
    {
        Console.WriteLine($"Результат {Paramint1}>{Paramint2}");
    }
    else
    {
        Console.WriteLine($"Результат {Paramint2}>{Paramint1}");
    }

}