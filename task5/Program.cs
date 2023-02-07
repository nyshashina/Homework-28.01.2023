// Написать программу вычисления произведения чисел от 1 до N
Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine() ?? "");

double mult = 1;
for(int i = 1; i <= numberA; i++)
{
    mult = mult * i;
}
Console.WriteLine("Произведение чисел от 1 до " + numberA + " равно " + mult);