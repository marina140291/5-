// задайте одномерный массив, заполненный случайными числами.
// найдите сумму элементов находящихся на нечетных позициях

void input_array(int[]array)
{
    for (int i = 0; i < array.Length; i++)
         array[i]=new Random().Next(1, 10);
}

void release(int[]array)
{int sum = 0;
for (int i = 0; i < array.Length; i = i + 2)
         sum += array[i];
    Console.WriteLine(sum);
}


Console.Clear();
Console.Write("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[]array=new int[n];
input_array(array);
Console.WriteLine($"[{string.Join(" ,  ", array)}]");
release(array);