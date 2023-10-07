Console.Clear();

int MetodManyNum(int count)
{
   Console.WriteLine("Веедите число " + count);
   string strNum = Console.ReadLine();
   int num = int.Parse(strNum);
   return num;
}

int MetodOneNum()
{
   Console.WriteLine("Веедите число");
   string strNum = Console.ReadLine();
   int num = int.Parse(strNum);
   return num;
}


// Задача 2
Console.WriteLine("Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее");

int num1 = MetodManyNum(1);
int num2 = MetodManyNum(2);

if (num1 > num2) Console.WriteLine("max = " + num1);
else Console.WriteLine("max = " + num2);


// Задача 4
Console.WriteLine();
Console.WriteLine("Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел");

num1 = MetodManyNum(1);
num2 = MetodManyNum(2);
int num3 = MetodManyNum(3);

int max = num1;

if (max < num2) max = num2;
if (max < num3) max = num3;

Console.WriteLine("Max = " + max);


// Задача 6
Console.WriteLine();
Console.WriteLine("Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)");

int num = MetodOneNum();
if (num == 0) Console.WriteLine("Ноль есть ноль)");
else
   if (num % 2 == 0) Console.WriteLine("Четное");
else Console.WriteLine("Нечетное");


// Задача 8
Console.WriteLine();
Console.WriteLine("Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N");

num = MetodOneNum();
if (num < 2) Console.WriteLine("Нет таких числе");
else {
   Console.Write("Это числа: ");
   for (int i = 2; i <= num; i = i + 2)
   Console.Write(i + ",");
}