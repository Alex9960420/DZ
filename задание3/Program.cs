// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num >= 10 && num <= 100)
{
int num1 = num % 10;
int num2 = num / 10; 
if (num1 > num2)
{
    Console.WriteLine($"{num1}");
}
else
{
    Console.WriteLine($"{num2}");
}
}
else
{
    Console.WriteLine("число не двухзначное");
}