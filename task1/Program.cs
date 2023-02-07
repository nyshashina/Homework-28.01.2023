// Найти кубы чисел от 1 до N
Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Таблица кубов чисел от 1 до " + numberA);
for(int i = 1; i <= numberA; i++)
{
    Console.WriteLine(i + " " + i * i * i);
}