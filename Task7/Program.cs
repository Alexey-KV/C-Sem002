// Задача №7. Напишите программу,
// которая принимает на вход трёхзначное число
// и на выходе показывает последнюю цифру этого числа.
//456 -> 6
//782 -> 2
//918 -> 8

Console.Write("Введите трёхзначное число: ");
int numN = Convert.ToInt32(Console.ReadLine());
int LastNumber = 0;
if(numN > 99 && numN < 1000)
{
    LastNumber = numN%10;
    Console.Write(LastNumber);
}
else
{
    Console.Write("Не корректный ввод");
}