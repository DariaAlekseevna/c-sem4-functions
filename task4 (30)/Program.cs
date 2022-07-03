// выводит массив из 8 элементов, заполненный еденицами и нулями в случ. порядке.


void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(0, 2);
        index++;
    }

}

void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(array[position]);
        position++;
    }
}

int[] array = new int [8]; //определили массив из 8 эл-тов

FillArray(array); //вызвали функцию заполнения массива
PrintArray(array); //вызвали функцию печати массива