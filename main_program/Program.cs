void Main()
{
    Console.Write("Введите массив строк, разделяя каждый элемент пробелом: ");
    string[] strings = (Console.ReadLine() ?? "0").Split();
    int count = 0;
    for (int i = 0; i < strings.Length; i++)
    {
        if (strings[i].Length <= 3)
            count++;
    }
    string[] result = new string[count];
    int j = 0;
    for (int i = 0; i < strings.Length; i++)
    {
        if (strings[i].Length <= 3)
        {
            result[j] = strings[i];
            j++;
        }
    }
    Console.Write("Результат: ");
    for (int i = 0; i < result.Length; i++)
    {
        Console.Write(result[i] + " ");
    }
    Console.WriteLine();
}

Main();
