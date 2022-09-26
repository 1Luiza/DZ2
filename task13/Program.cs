/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6

(Number % Math.Pow(10, dvuhznachnost + 1) / Math.Pow(10, dvuhznachnost));
*/

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
void ThirdDigit (int Number)
{
    int znachnost = (int)Math.Log10(Number)-2;
    if(znachnost < 0)
    {
        Console.WriteLine("третьей цифры нет");
    }
    else
    {
        int thirdDigit = Number % (int)Math.Pow(10, znachnost + 1) / (int)Math.Pow(10, znachnost);
        Console.WriteLine(thirdDigit);
    }
}
Console.WriteLine(Number);
ThirdDigit(Number);


   

