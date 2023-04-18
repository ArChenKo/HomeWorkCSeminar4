// Программа, которая задаёт массив из 8 элементов и выводит их на экран.
int[] Arr(int len, int ls, int rs)
{
    int[] arr = new int[len];
    Random random = new Random();
    for (int i = 0; i < len; i++)
        arr[i] = random.Next(ls, rs);
    return arr;
}
void WriteArr(int[] array)
{
    for(int i=0;i<array.Length;i++)
    {
        if(array[i]>9 && array[i]<100)
            Console.WriteLine($"{i+1}|  {array[i]}");
        else if(array[i]>99)
            Console.WriteLine($"{i+1}| {array[i]}");
        else
            Console.WriteLine($"{i+1}|   {array[i]}");
    }
}
int[] array = Arr(8,0,150);
WriteArr(array);