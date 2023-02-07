// Определить, присутствует ли в заданном массиве, некоторое число
/*Console.WriteLine("");
Console.WriteLine("Введите число");
int numberA = int.Parse(Console.ReadLine() ?? "0");*/

Console.WriteLine("Задан массив:");
int[] arr = new int[8];
for (int i = 0; i < 8; i++){
    arr[i] = new Random().Next(0,100);
    Console.Write(arr[i] + " ");
}

Console.WriteLine("");
Console.WriteLine("Введите число");
int numberA = int.Parse(Console.ReadLine() ?? "0");

int count = 0;
for(int i = 0; i < 8; i++){
    if(arr[i] == numberA){
        Console.WriteLine("Число " + numberA + " присутствует в заданном массиве");
        count++;
        break;
    }
}
/*foreach(int el in arr){
    Console.Write(arr[el] + " ");
}*/


if(count == 0){
    Console.WriteLine("Число " + numberA + " не найдено в заданном массиве");
}