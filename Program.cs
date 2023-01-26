string[] CreateRandomArray(int size)
{
    string[] array = new string[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write("Input a number: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void ShowArray(string[] array)
{
    for(int  i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

void Check(int size, string[] array)
{
    Console.Write("Ответ: ");
    for(int i = 0; i < size; i++)
        if(array[i].Length - 1<=3)
                Console.Write(array[i] + " ");
}


