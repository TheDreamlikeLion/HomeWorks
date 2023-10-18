int InputInteger(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void ShowNumsDescending (int n)
{
    if (n > 0)
    {
        System.Console.Write(n + " ");
        ShowNumsDescending(n - 1);
    }
}

System.Console.Clear();
Console.WriteLine("Dannaya programma vyvedet vse natural`nye chisla ot N do 1.");
int n = InputInteger("Vvedite chislo N: ");
Console.WriteLine();
Console.WriteLine($"[{n} .. 1]: ");
ShowNumsDescending(n);
Console.WriteLine();
Console.ReadLine();
//Конец программы.
System.Console.Clear();

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ShowSum(int m, int n)
{
    if (m != n)
    {
        if(m < n)
        {
            return ShowSum(m + 1, n) + m;
        }
        else
        {
            return ShowSum(m, n + 1) + n;
        }
    }
    else return m;
}

Console.WriteLine("Dannaya programma naydet summu natural`nyh chisel v promejutke ot M do N.");
int m = InputInteger("Vvedite chislo M: ");
n = InputInteger("Vvedite chislo N: ");
Console.WriteLine();
Console.WriteLine($"M = {m}; N = {n} -> {ShowSum(m, n)}");


Console.ReadLine();
//Конец программы.
System.Console.Clear();

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int m, int n)
{
    if(m > 0 && n > 0)
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
    else
    {
        if(m == 0)
        {
            return (n + 1);
        }
        else
        {
            return Akkerman(m - 1, 1);
        }
    }
}

Console.WriteLine("Dannaya programma vycheslit funkciyu Akkermana dlya neotricatel`nyh chisel m i n.");
m = InputInteger("Vvedite chislo m: ");
n = InputInteger("Vvedite chislo n: ");
Console.WriteLine();
if(m >= 0 && n >= 0)
{
    Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {Akkerman(m, n)}");
}
else Console.WriteLine("Vy vveli otricatel'noe chislo.");

Console.ReadLine();
//Конец программы.
System.Console.Clear();
Console.WriteLine("Spasibo za ispol'zovanie etoy programmy.");
Console.ReadLine();
System.Console.Clear();