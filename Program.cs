//The Verification work

Console.Clear();


Console.Write("Enter length array:");
int sizeArray = Convert.ToInt32(Console.ReadLine());

string[] mixedArray = new string[sizeArray];

for (int i = 0; i < sizeArray; i++)
{
    Console.Write($"Enter {i + 1} element: ");
    mixedArray[i] = Console.ReadLine();
}

string newElement = "";
string[] finalArray = mixedArray;
int j = 0;

foreach (string item in mixedArray)
{
    for (int i = 0; i < item.Length; i++)
    {
        if (item[i] < '0' || item[i] > '9')
        {
            newElement += item[i];
        }
    }
    finalArray[j] = newElement;
    j++;
    newElement = "";
}
Console.WriteLine(String.Join("-", finalArray));
Console.WriteLine();