void Prompt(string[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"\nВведите {i} строку:\t ");
        array[i] = Console.ReadLine()!;
    }
}

void PrintArray(string[] array) 
{
    Console.Write("{");

    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("}");

}

void SortArray(string[] array) 
{
    Console.Write("{");
    for (int i = 0; i < array.Length; i++)
    {
        string text = String.Empty;
        text = array[i];

        int length = text.Length;

        string result = String.Empty;

        for (int j = 0; j < length; j++)
        {
            if (length < 4)
            {
                result = result + $"{text[j]}";
            }
            else break;
        }
        Console.Write($"{result}" + " ");
    }
    Console.Write("}");
}


Console.Write("Введите количество строк: \t");
int lines = int.Parse(Console.ReadLine()!);

string[] ArrString = new string[lines];
Prompt(ArrString);
Console.Write($"\n Заданный массив: ");
PrintArray(ArrString);
Console.WriteLine();
Console.Write("\n Отсортированный массив: ");
SortArray(ArrString);
