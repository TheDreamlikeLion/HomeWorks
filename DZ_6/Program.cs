// Задача 41.
// Программа для подсчета положительных чисел среди М чисел, введенных пользователем.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Vvedite element s indeksom {i}  ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine($"Spasibo.");
    Console.WriteLine();
    return array;
}


int[] ArrayInfo(int[] array)
{
    int[] info = new int[3];
    info[0] = 0;
    info[1] = 0;
    info[2] = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0 )
        {
            info[0] = info[0] + 1;
        }
        if(array[i] < 0 )
        {
            info[1] = info[1] + 1;
        }
        if(array[i] == 0 )
        {
            info[2] = info[2] + 1;
        }
    }
    return info;
}

void PrintArray(int[] array)
{
    System.Console.Write("[ ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write(array[i] + ", ");
    }
    System.Console.Write($"{array[(array.Length - 1)]} ]");
}

double[] CreateArray(double k1, double k2, double k3, double k4)
{
    double[] array = new double[4];
    array[0] = k1;
    array[1] = k2;
    array[2] = k3;
    array[3] = k4;
    return array;
}

double[] GetCross(double[] k)
{
    double[] result = new double[2];
    result[0] = (k[3] - k[1]) / (k[0] - k[2]);
    result[1] = k[0] * (k[3] - k[1]) / (k[0] - k[2]) + k[1];
    return result;
}

System.Console.Clear();
Console.WriteLine("Programa dlya podscheta polojitel`nyh chisel sredi M chisel, vveddennyh pol`zovatelem.");
Console.WriteLine("Vvedi kolichestvo elementov.");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = GetArray(num);
int[] info = ArrayInfo(array);

Console.WriteLine($"Vy vveli sleduyushchie chisla:");
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Sredi nih polojitel`nyh chisel:\t\t{info[0]} ,");
Console.WriteLine($"otricatel`nyh chisel:\t\t\t{info[1]} ,");
Console.WriteLine($"i ravnyh 0:\t\t\t\t{info[2]} .");
Console.ReadLine();
//Конец программы.
System.Console.Clear();

// Задача 43.
// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Programa dlya nahojdeniya tochki peresecheniya dvuh pryamyh, zadannyh uravneniyami.");

Console.WriteLine("Vvedite koefficienty v uravneniyah");
Console.WriteLine("\t y = K1 * x + B1, y = K2 * x + B2");
Console.Write("K1 = ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("B1 = ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("K2 = ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("B2 = ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Poluchilis` uravneniya:");
Console.WriteLine($"    y = {k1} * x + {b1}    i    y = {k2} * x + {b2} .");

double[] koef = CreateArray(k1, b1, k2, b2);
double[] cross = GetCross(koef);

Console.WriteLine();
Console.WriteLine($"Dannye pryamye peresekutsya v tochke c koordinatami [ {Math.Round(cross[0], 2)}, {Math.Round(cross[1], 2)} ] .");


Console.ReadLine();
//Конец программы.
System.Console.Clear();
Console.WriteLine("Spasibo za ispol'zovanie etoy programmy.");
Console.ReadLine();
System.Console.Clear();