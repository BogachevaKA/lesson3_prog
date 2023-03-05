//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом. Через строку решать нельзя.
//14212 -> нет
//12821 -> да
//23432 -> да

void CheckPalindromicNumber(int number)
{
    if (number >= 10000 && number < 100000)
    {
        int div1 = number / 10000;
        int rem1 = number % 10;
        if (div1 == rem1)
        {
            number = number / 10;
            int div2 = (number / 100) % 10;
            int rem2 = number % 10;
            if (div2 == rem2)
                Console.WriteLine("Число является палиндромом");
        }
        else
            Console.WriteLine("Число не палиндром");
    }
    else
        Console.WriteLine("Число введено не корректно");
}
Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine()!);
CheckPalindromicNumber(number);