// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

Console.Clear();
Console.Write("Введите число: ");
int num=int.Parse(Console.ReadLine());
int result=0;

if(num>99)
{
    while(num>999)
    {
        num = num/10;
    }
result=num%10;
Console.WriteLine($"Третья цифра {result}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
