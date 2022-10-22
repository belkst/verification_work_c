//The Verification work

Console.Clear(); //очищаем консоль


Console.Write("Enter length array:"); 
int sizeArray = Convert.ToInt32(Console.ReadLine()); //получаем размер массива строк

string[] mixedArray = new string[sizeArray];

for (int i = 0; i < sizeArray; i++)//заполняем массив строк
{
    Console.Write($"Enter {i + 1} element: ");
    mixedArray[i] = Console.ReadLine();
}

string newElement = "";//создали строковую переменную, для записи в нее посимвольной "очистки"
string[] finalArray = mixedArray;//результирующий массив
int j = 0;

foreach (string item in mixedArray)//перебираем массив строк
{
    for (int i = 0; i < item.Length; i++)//перебираем строку посимвольно
    {
        if (item[i] < '0' || item[i] > '9')//делаем выборку
        {
            newElement += item[i];//записываем выборку в строковую переменную
        }
    }
    finalArray[j] = newElement;//записываем полученную строку в элемент массива
    j++;
    newElement = "";//обнуляем строковую переменную
}
Console.WriteLine(String.Join("-", finalArray));//печатаем результирующий массив
Console.WriteLine();