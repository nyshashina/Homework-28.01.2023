// Показать кубы чисел, заканчивающихся на четную цифру
Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Таблица четных кубов чисел от 1 до " + numberA);
for(int i = 2; i <= numberA; i++)
{
    Console.WriteLine(i + " " + i * i * i);
    i = i + 1;
}