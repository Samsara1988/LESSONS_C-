Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine());
if (n > m)
{
    Console.WriteLine("максимальное число:"+n);
    Console.WriteLine("минимальное число:"+m);
}
else
{
    Console.WriteLine("максимальное число:"+m);
    Console.WriteLine("минимальное число:"+n);
}