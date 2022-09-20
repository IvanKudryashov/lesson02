//программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
void zadacha10 ()
{
    Console.WriteLine("Введите трехзначное число:");
    int number = Convert.ToInt32(Console.ReadLine());
    number = number / 10 % 10;
    Console.WriteLine("Второе число: " + number);
}

//программа, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
void zadacha13 ()
{
    Console.WriteLine("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    int num1 = 0;
    if (number/100 == 0)
    {
        Console.WriteLine("третьей цифры нет");
    }
    else { while (Math.Abs(number/10) > 10)
    {
        num1 = number % 10;
        number = number / 10;
    }
    Console.WriteLine("Третье число: " + Math.Abs(num1));
    }

}

//программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
void zadacha15 ()
{
    Console.WriteLine("Введите цифру от 1 до 7:");
    int n = Convert.ToInt32(Console.ReadLine());
    string[] array = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
    if (array[n-1] == "Суббота" || array[n-1] == "Воскресенье")
    Console.WriteLine($"{n} выходной - {array[n-1]}");
    else Console.WriteLine($"{n} рабочий день - {array[n-1]}");

}
zadacha10 ();
//zadacha13 ();
//zadacha15 ();