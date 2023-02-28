Console.Write("Введите число: ");
int numN = Convert.ToInt32(Console.ReadLine());
int temp = -numN;
while(temp <= numN)
{
    Console.Write($"{temp} ");
    temp++; // temp = temp + 1
}
