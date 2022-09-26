/* 
Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int Number = new Random().Next(1,8);

void Weekend(int Number)
{
    if (Number > 5)
    {
        Console.WriteLine($"да");
    } 
    else Console.WriteLine($"нет");
}

Console.WriteLine(Number);
Weekend(Number);