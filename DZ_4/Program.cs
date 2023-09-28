// Задача 25.
// Программа для написания цикла, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int VStepen (int num, int step)
{
    int result = 1;
    for (int i = 1; i <= step; i++)
    {
        result = result * num;
    }
    return result;
}

System.Console.Clear();
Console.WriteLine("Programa dlya vozvedeniya pervogo vvedennogo chisla v stepen`, ravnuyu vtoromu vvedennomu chislu.");
Console.WriteLine("Vvedi chislo.");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("V kakuyu stepen` ego vozvesti?");
int step = Convert.ToInt32(Console.ReadLine());

int result = VStepen(num, step);

Console.WriteLine($"Chislo {num} v stepeni {step} ravno {result} .");

Console.ReadLine();
//Конец программы.
System.Console.Clear();

// Задача 27.
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SummaCifr (int num)
{
    int result = num % 10;
    for (int i = 1; (num / 10) > 0; i++)
    {
        num = num / 10;
        result = result + (num % 10);
    }
    return result;
}

System.Console.Clear();
Console.WriteLine("Programa dlya summirovaniya vseh cifr vvedennogo chisla.");
Console.WriteLine("Vvedi chislo.");
num = Convert.ToInt32(Console.ReadLine());

result = SummaCifr(num);

Console.WriteLine($"Summa cifr chisla {num} ravna {result} .");


Console.ReadLine();
//Конец программы.
System.Console.Clear();

// Задача 29.
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue +1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.Write("]");
}

System.Console.Clear();
Console.WriteLine("Programa dlya vyvoda massiva is sluchaynyh elementov.");
Console.WriteLine();
Console.WriteLine("Jelaete zadat` parametry massiva samostoyatel`no?");
Console.WriteLine("Yes - neobhodimo bedet vvesti razmer massiva i granicy diapazona znacheniy,");
Console.WriteLine("v inom sluchae budet sformirovan massiv iz 8 elementov s diapazonom znacheniy [0..100].");
Console.WriteLine();
Console.Write("Podtverdite Vash vybor/ (Yes) ");
string choice = (Console.ReadLine());
System.Console.Clear();

int size = 8;
int min = 0;
int max = 100;
if (choice == "Yes" || choice == "yes" || choice == "y" || choice == "Y" || choice == "Да" || choice == "да" || choice == "нуы" || choice == "Нуы")
{
    System.Console.Write("Vvedite razmer massiva: ");
    size = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Vvedite minimal`noe znachenie elementov: ");
    min = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Vvedite maksimal`noe znachenie elementov: ");
    max = Convert.ToInt32(Console.ReadLine());
}

System.Console.Clear();
PrintArray(CreateArray(size, min, max));


Console.ReadLine();
//Конец программы.
System.Console.Clear();
Console.WriteLine("Spasibo za ispol'zovanie etoy programmy.");
Console.ReadLine();
System.Console.Clear();