/* Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int Number = new Random().Next(100,1000);
int getSecondDigitFromNumber(int Number)
{
    int secondDigit = new int();
    secondDigit = (Number / 10) % 10;
    return(secondDigit);
}
Console.WriteLine(Number);
int result = getSecondDigitFromNumber(Number);
Console.WriteLine(result);

