// Напишите программу, которая задаёт массив 
//из 8 элементов и выводит их на экран.1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//(*) В 3-й задаче Доп сложность. Ввод с консоли “введите количество элементов массива”, 
//“Введите минимальный порог случайных значений”, 
//“Введите максимальный порог случайных значений”
int ReadInt(string message)
 {
    System.Console.Write(message);
    int inputedNum = Convert.ToInt32(Console.ReadLine());
    return inputedNum;
}
int[] GetArray(int length, int minValue, int maxValue)//получение массива случайных чисел
{
    int[] array = new int [length];
    Random random = new Random();
    for (int i = 0;i < length; i ++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i ++)
    {
    System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.WriteLine("]");
}
int length = ReadInt("Введите количество элементов массива: ");//необходимо  ввести число 8
int minValue = ReadInt("Введите минимальный порог случайных значений: ");
int maxValue = ReadInt("Введите максимальный порог случайных значений: ");
int[] array = GetArray(length, minValue, maxValue);
PrintArray(array);
