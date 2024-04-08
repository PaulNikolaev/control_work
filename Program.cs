string[] CreateArray(int n)   // Создание первоначального массива строк
{
    string[] array = new string[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = Console.ReadLine()!;
    }
    return array;
}

string[] CreateConversionArray(string[] array)  // Создание массива из сторок, длина которых меньше, либо равна 3 символам. 
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {    
            count++;
        }
    }
    int cnt = 0;
    string[] convertArray = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            convertArray[cnt] = array[i];
            cnt++;
        }
    }
    return convertArray;
}


Console.Clear();
Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] ConvertArray = CreateConversionArray(CreateArray(n));
Console.Write("Отфильтрованный массив: ");
Console.WriteLine("[{0}]", string.Join(", ", ConvertArray));






