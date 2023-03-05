string Check_N(int N)
{
    int num1 = N / 1000;
    int num2 = num1 / 10;
    int num3 = num1 % 10;
    int num4 = N % 100;
    int num5 = num4 / 10;
    int num6 = num4 % 10;
    string res = "Введены некоректные данные";
    if (num2 == num6 & num3 == num5)
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