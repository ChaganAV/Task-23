// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
while(count <= num)
{
    //Console.WriteLine($"{count} в кубе = {count*count*count}");
    if (count == num)
        Console.Write($"{GetCube(num)}");
    else
        Console.Write($"{GetCube(num)}, ");
    count++;
}

int GetCube(int num)
{
    return num*num*num;
}