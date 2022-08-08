void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10); // В позицию [index] кладем новое случайное число от 1 до 10
        //index = index + 1
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length; //Кол-во элементов
    int posittion = 0;
    while (posittion < count)
    {
        Console.WriteLine(col[posittion]);
        posittion++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;


    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; //Определяем массив 


FillArray(array); //метод, заполняющий массив
array[4] = 4;
array[5] = 4;

PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
