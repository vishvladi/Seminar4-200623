// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
int ReadInt(string message)
 {
    System.Console.Write(message);
    int inputedNum = Convert.ToInt32(Console.ReadLine());
    return inputedNum;
}
int SumDigitsInnum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number = number / 10;
    }
    return sum;
}
int num = ReadInt("Введите число: ");
Console.WriteLine($"Сумма всех цифр в числе {num} равна { SumDigitsInnum(num)} ");
