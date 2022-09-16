Console.Clear();
string[] ArrayOfStrings = new string[] { };
Console.Write("Введите количество элементов массива - строк:");
int n = int.Parse(Console.ReadLine());
ArrayOfStrings = new string[n];
for (int i = 0; i < ArrayOfStrings.Length; i++)
{
    Console.Write($" Введите {i + 1} строку: ");
    ArrayOfStrings[i] = Console.ReadLine();
}
Console.WriteLine();
Console.WriteLine("массив введенных данных:");
Console.WriteLine($"{PrintArray(ArrayOfStrings)}");
Console.WriteLine();

int length = 3;  // задаем парметр длины элемент массива, который согласно заданию озвучен



// функция вывода массива
string PrintArray(string[] array)
{
    string result = string.Empty;
    result = "[ ";
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i],1}";
        if (i < array.Length - 1) result += ", ";
    }
    result += " ]";
    return result;
}