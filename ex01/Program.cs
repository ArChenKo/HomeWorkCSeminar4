// Программа с циклом, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int GetNumber (string message)
{
    Console.Write(message);
    int number=int.Parse(Console.ReadLine()!);
    return number;
}
long PowerN (int num, int pow)
{
    long result=1;
    for (int i =1; i <=pow; i ++)
        result = result * num;
    return result;
}
int number = GetNumber("Введите основание: ");
int pownum = GetNumber("Введите степень числа: ");
long respow = PowerN(number,pownum);
Console.WriteLine($"Результат возведения в степень = {respow}");