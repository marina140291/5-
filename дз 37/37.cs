// Задача 38: Задайте массив чисел. Найдите разницу между максимальным и минимальным элементов массива.

void input_array(int[]array)
{
    for (int i = 0; i < array.Length; i++)
         array[i]=new Random().Next(1, 10);
}

void release(int[]array)
{
int Max = array[0];
int Min = array[0];

for (int i = 0; i < array.Length; i++)
    if (Max < array[i])
         Max = array[i];
    else   
       if (Min > array[i])
       Min = array[i];

    Console.WriteLine(Max);
    Console.WriteLine( Min);
    Console.WriteLine(Max - Min);
}


Console.Clear();
Console.Write("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[]array=new int[n];
input_array(array);
Console.WriteLine($"[{string.Join(" ,  ", array)}]");
release(array);
