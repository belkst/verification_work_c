//The Verification work

Console.Clear();

int SetSizeArray() // set size array
{
    Console.WriteLine("Задайте размер массива, с значением больше 5 элементов");
    int size = Convert.ToInt32(Console.ReadLine());
    while (size<=4)
    {
        Console.WriteLine("Вы ввели неверное значение (4 или меньше), пожалуйста, повторите ввод:");
        size = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
    }
    return size;
}



SetSizeArray();