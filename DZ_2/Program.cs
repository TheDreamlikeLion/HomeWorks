// Задача 10.
// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.

int Find2ndDigit(int num)
{
    int dec = num / 10;
    int hung = num / 100;
    num = dec - (10 * hung);
    return num;
}

System.Console.Clear();
Console.WriteLine("Programa dlya vyvoda vtoroy cifry trehznachnogo chisla.");
Console.WriteLine("Vvedi trehznachnoe chislo.");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 100 || num > 999)
{
    Console.WriteLine($"Dannoe chislo ne udovletvoryaet trebovaniyam.");
}
else
{
int result = Find2ndDigit(num);
Console.WriteLine($"Srednyaya cifra chisla {num} - {result} .");
}

Console.ReadLine();
//Конец программы.
System.Console.Clear();

// Задача 13.
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int GetLastDigit (int num2)
{
    int ed = (num2 % 10);
    return(ed);
}

System.Console.Clear();
Console.WriteLine("Programa dlya nahojdeniya tret`ey cifry c nachala chisla.");
Console.WriteLine("Vvedi lyuboe chislo.");
int num2 = Convert.ToInt32(Console.ReadLine());
int result2 = 0;

if(num2 < 100)
{
    Console.WriteLine("Tret`ey cifry net.");
}
else
{
    Console.Write($"Tret`ya cifra (c nachala) chisla {num2} - ");
    while(num2 >= 100)
    {
        result2 = GetLastDigit(num2);
        num2 = num2 / 10;
    }
}

Console.WriteLine($"{result2} .");

Console.ReadLine();
//Конец программы.
System.Console.Clear();

// Задача 15.
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
string DayName (int day)
{
    string name = "";
    if(day == 1)
    {
    name = "Ponedel`nik.";
    }
    if(day == 2)
    {
    name = "Vtornik.";
    }
    if(day == 3)
    {
    name = "Sreda.";
    }
    if(day == 4)
    {
    name = "Chetverg.";
    }
    if(day == 5)
    {
    name = "Pyatnica.";
    }
    if(day == 6)
    {
    name = "Subbota.";
    }
    if(day == 7)
    {
    name = "Voskresen`e.";
    }
    return(name);
}

bool CheckVyhi(int day)
{
    if(day >= 6)
    {
        return true;
    }
    else
    {
        return false;
    }
}

System.Console.Clear();
Console.WriteLine("Programa dlya proverki dnya nedeli (po nomeru) na to, yavlyaetsya li on vyhodnym.");
Console.WriteLine("Vvedi poryadkovyy nomer dnya nedeli [1..7].");
int day = Convert.ToInt32(Console.ReadLine());
if(day >= 1 && day <= 7)
{
    string dayname = DayName(day);
    Console.Write($"Vy vveli {day} - {dayname}");
    Console.ReadLine();
    bool result3 = CheckVyhi(day);
    if(result3 == true)
    {
        Console.WriteLine("Etot den` nedeli - vyhodnoy. Ura! =)");
    }
    else
    {
        Console.WriteLine("Etot den` nedeli - NE vyhodnoy. Uvy. =(");
    }
}
else
{
    Console.WriteLine("Vvedenno nepravil`noe chislo. Neobhodimo vvesti ot 1 do 7.");
}


Console.ReadLine();
//Конец программы.
System.Console.Clear();
Console.WriteLine("Spasibo za ispol'zovanie etoy programmy.");
Console.ReadLine();