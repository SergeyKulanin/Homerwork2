// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Clear();
Console.Write("Введите цифру, обозначающую день недели: ");
int num = int.Parse(Console.ReadLine());

if(num==6 || num==7)
{
    Console.WriteLine("Это выходной день");
}
else
{
    Console.WriteLine("Это рабочий день");
}