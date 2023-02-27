// Метод для заполнения массива пользователем
string[] FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите слово: ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}

//Метод для вывода массива в терминал
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"'{array[i]}', ");
    }
    Console.Write("\b\b]");
}

//Метод для формирования массива из строк, длина которого <= 3 символам
//и вывода этого массива в терминал.
void CheckArray (string[] array)
{
    int count = 0;
    string [] newArray = new string [array.Length];//новый массив для хранения строк
    Console.Write(" -> [");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].ToString().Length <= 3)
        {
        newArray[count] = array[i];
        Console.Write($"'{newArray[count]}', ");
        count ++;
        } 
    }
    Console.Write("\b\b]");
}

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];
FillArray(array);
PrintArray(array);
CheckArray(array);