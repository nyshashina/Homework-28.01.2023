// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
int[] arr = new int[8];
foreach(int el in arr){
    arr[el] = new Random().Next(0,2);
    Console.Write(arr[el] + " ");
}
