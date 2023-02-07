// Подсчитать сумму цифр в числе
Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine() ?? "");

int sum = 0;
int numberB = numberA;
while (numberB > 0)
{
    sum = sum + numberB % 10;
    numberB = numberB / 10;
}
Console.WriteLine("Сумма цифр в числе " + numberA + " равна " + sum);