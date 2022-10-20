//The Verification work

Console.Clear();

// int SetSizeArray() // set size array
// {
//     Console.WriteLine("Задайте размер массива, с значением больше 5 элементов");
//     int size = Convert.ToInt32(Console.ReadLine());
//     while (size<=4)
//     {
//         Console.WriteLine("Вы ввели неверное значение (4 или меньше), пожалуйста, повторите ввод:");
//         size = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine();
//     }
//     return size;
// }

char[] mixedArray = Convert.ToChar("Ал0е3к2с32андр23 Пу465шкин на7ча7л пи7с7а7ть");

// char[] newStrArray = new char[];
// int k = 0;
foreach (int v in mixedArray)
{
    if (mixedArray[v] == 0)
    {
        Console.WriteLine(mixedArray[v]);
       
    }
}

// Console.WriteLine(string.Join(newStrArray));
// string[] NewFillArrayString(int sizeArray)
// {
//     string[] newFillArray = new string[sizeArray];
//     for (int i = 0; i < sizeArray; i++)
//     {
//         newFillArray[i] = new Random().Next(0, 1000).ToString();
//         System.Console.WriteLine(newFillArray[i]);
//     }
//     return newFillArray;
// }



