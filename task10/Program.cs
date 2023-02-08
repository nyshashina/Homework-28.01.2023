// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
Console.WriteLine("Задан массив:");

int count = 0;
int[] arr = new int[123];
for (int i = 0; i < 123; i++){
    arr[i] = new Random().Next(0,1000);
    Console.Write(arr[i] + " ");
    if(arr[i] >= 10 && arr[i] <= 99){
        count++;
    }
}
Console.WriteLine("");
Console.WriteLine("Количество элементов из отрезка [10,99] в этом массиве равно " + count);
