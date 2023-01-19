// задайте массив заполненный случайными положительными трехзначными  числами
// напишите программу, котрая покажет количество четных чисел в массиве

void input_array(int[]array)
{
    for (int i=0; i< array.Length; i++)
         array[i]=new Random().Next(100,1000);
}

int release(int[]array)
{
int count=0;
for (int i =0; i<array.Length; i++)
     if (array[i] % 2 == 0)
         count ++;
     return count;
}


Console.Clear();
Console.Write("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[]array=new int[n];
input_array(array);
Console.WriteLine($"[{string.Join(" ,  ", array)}]");
Console.WriteLine(release (array));