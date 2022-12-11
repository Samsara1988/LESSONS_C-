Console.WriteLine("введите число");
int i= Convert.ToInt32(Console.ReadLine());
int j = 1;
while (j <= i)
{
    int result = j % 2;
    if (result != 1)
{
    Console.WriteLine("четное " + j);
    j++;
}
else
{
    j++;
}
}