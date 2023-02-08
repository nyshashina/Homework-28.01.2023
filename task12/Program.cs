// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Console.WriteLine("Задан массив:");

int[] arr = new int[10];
for (int i = 0; i < 10; i++){
    arr[i] = new Random().Next(0,10);
    Console.Write(arr[i] + " ");
}
Console.WriteLine("");
Console.WriteLine("Произведения пар чисел в этом массиве:");
for(int i = 0; i < (arr.Length / 2); i++){
    Console.Write(arr[i] +" * " + arr[arr.Length - i -1] + " = ");
    Console.Write(arr[i] * arr[arr.Length - i -1]);
    Console.WriteLine("");
}
