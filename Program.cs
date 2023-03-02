// Task 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondNumber(int num)
{
    return num / 10 % 10;
}

Console.Write("Input a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99 && number < 1000)
{
    Console.WriteLine(SecondNumber(number));
}
else
{
    Console.WriteLine("The input number is not a three-digit number, try again!");
}



// Task 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThirdNumber(int number)
{
    while(number > 999)
    {
        number = number / 10;
    }
    return Math.Abs(number % 10);
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 99 || num < -99)
   Console.WriteLine(ThirdNumber(num)); 
else
    Console.WriteLine("The input number doesn't have the third number");





// Task 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.


bool IsDayWeekend(int number)
{
    return number == 6 || number == 7;
}

Console.Write("Input the number of the day: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 0 && num < 8)
Console.WriteLine(IsDayWeekend(num));
else
Console.WriteLine("The input number is incorrect - we don't have a day of the week with such a number");

*/

