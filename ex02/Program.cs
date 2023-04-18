// Программа, которая принимает на вход число и выдаёт сумму цифр в числе.
void WriteSum(int sum)
{
    Console.WriteLine($"Сумма цифр во введенном чиле = {sum}");
}
int GetNum(string mes)
{
    Console.Write(mes);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
int SumNumbers(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}
int number = GetNum("Введите число: ");
int sum = SumNumbers(number);
WriteSum(sum);