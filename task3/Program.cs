// Возведите число А в натуральную степень B, используя цикл
Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите степень: ");
int numberB = int.Parse(Console.ReadLine() ?? "");

int degree = 1;
for(int i = 1; i <= numberB; i++)
{
    degree = degree * numberA;
}
Console.WriteLine("Число " + numberA + ", возведенное в степень " + numberB + ", равно " + degree);