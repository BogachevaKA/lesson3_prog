string Check_N(int N)
{
    int num1 = N / 10000;
    int num2 = N / 1000;
    int num3 = N % 100;
    int num4 = num3 / 10;
    int num5 = num3 % 10;
    string res = "Введены некоректные данные";
    if (num1 == num5 & num2 == num4)
        Console.WriteLine("Число " + N + " является палиндромом");
    else
        Console.WriteLine("Число " + N + " не является палиндромом");
    return res;
}
try
{
    Console.WriteLine("Введите пятизначное число для проверки");
    int n = Convert.ToInt32(Console.ReadLine());
    Check_N(n);
    Console.WriteLine(Check_N(n));
}
catch
{
    Console.WriteLine("Были введены некорректные данные");
}