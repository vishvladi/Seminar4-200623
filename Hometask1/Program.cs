// Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
int ReadInt(string message)
 {
    System.Console.Write(message);
    int inputedNum = Convert.ToInt32(Console.ReadLine());
    return inputedNum;
}
int Involution(int number, int exponent)
{
    int result = 1;
    for (int i = 0; i < exponent; i ++)
    {
        result *= number;
    }
    return result;
}
bool ValidateExponent(int exponent)
{
    if (exponent < 0)
    {
        Console.WriteLine("Показатель степени не должен быть меньше нуля");
        return false;
    }
    return true;
}
int num = ReadInt("Введите число: ");
int exponent = ReadInt("Введите показатель степени: ");
if(ValidateExponent(exponent))
{
  Console.WriteLine($"Число {num} в степени {exponent} равно {Involution(num, exponent)}");  
}