string[] array1 = new string[5] {"56", "task", "yes", "family", "no"};
string[] array2 = new string[array1.Length];
void Array(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void conclusion(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Array(array1, array2);
conclusion(array2);
