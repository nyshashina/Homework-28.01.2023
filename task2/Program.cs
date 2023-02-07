// Найти сумму чисел от 1 до А
Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine() ?? "");

int sum = 0;
for(int i = 1; i <= numberA; i++)
{
    sum = sum + i;
}
Console.WriteLine("Сумма чисел от 1 до " + numberA + " равна " + sum);