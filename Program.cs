//Программа, которая на вход принимает два числа и выдает, какое из них является большим, а какое меньшим.
System.Console.Clear();
Console.WriteLine("Nahodim bol'shee i men'shee iz 2uh vvedennyh chisel.");
Console.WriteLine("Vvedi pervoe chislo.");
int Chislo1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedi vtoroe chislo.");
int Chislo2 = Convert.ToInt32(Console.ReadLine());
if(Chislo1 == Chislo2)
{
    Console.WriteLine($"Chisla {Chislo1} i {Chislo2} - odinakovy.");
}
else
{
    if(Chislo1 > Chislo2)
    {
        Console.WriteLine($"Chislo {Chislo1} - bol'shee, a chislo {Chislo2} - men'shee.");
    }
    else
    {
        Console.WriteLine($"Chislo {Chislo2} - bol'shee, a chislo {Chislo1} - men'shee.");
    }
}

Console.ReadLine();
//Программа, которая на вход принимает три числа и выдает максимальное из этих чисел.
System.Console.Clear();
Console.WriteLine("Nahodim maksimalnoe iz 3eh vvedennyh chisel.");
Console.WriteLine("Vvedi pervoe chislo.");
Chislo1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedi vtoroe chislo.");
Chislo2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedi tret'e chislo.");
int Chislo3 = Convert.ToInt32(Console.ReadLine());
int max = Chislo1;
if(Chislo1 == Chislo2 && Chislo2 == Chislo3)
{
    Console.WriteLine($"Vse chisla odinakovy.");
}
else
{
    if(Chislo2 > max)
    {
        max = Chislo2;
    }
    if(Chislo3 > max)
    {
        max = Chislo3;
    }
}
Console.Write($"Sredi chisel {Chislo1}, {Chislo2}, {Chislo3} ");
Console.WriteLine($"maksimal'noe chislo - {max}.");

Console.ReadLine();
//Программа, которая на вход принимает число и выдает, является ли оно четным.
System.Console.Clear();
Console.WriteLine("Proveryaem, yavlyaetsya li vvedennoe chislo chetnym.");
Console.WriteLine("Vvedi chislo.");
Chislo1 = Convert.ToInt32(Console.ReadLine());
if(Chislo1%2 == 0)
{
    Console.WriteLine($"Chislo {Chislo1} yavlyaetsya chetnym.");
}
else
{
    
    Console.WriteLine($"Chislo {Chislo1} ne yavlyaetsya chetnym.");
}

Console.ReadLine();
//Программа, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N.
System.Console.Clear();
Console.WriteLine("Nahodim vse chetnye chisla ot 1 do vvedennogo chisla.");
Console.WriteLine("Vvedi chislo.");
Chislo2 = Convert.ToInt32(Console.ReadLine());
Chislo1 = 2;
if(Chislo2 < 2)
{
    Console.WriteLine("Net chetnyh chisel s uchetov dannyh usloviy. Vvedite chislo bol'she 2.");
} 
else
{
    Console.WriteLine($"Chetnye chisla ot 1 do {Chislo2}:");
    Console.Write($"{Chislo1}");
    while(Chislo1+2 <= Chislo2)
    {
        Chislo1 += 2;
        Console.Write($", {Chislo1}");
    }
    Console.WriteLine($".");
}

Console.ReadLine();
//Конец программы.
System.Console.Clear();
Console.WriteLine("Spasibo za ispol'zovanie etoy programmy.");
Console.ReadLine();
System.Console.Clear();