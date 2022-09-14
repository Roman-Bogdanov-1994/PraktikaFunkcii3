Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int max_f = n;
int max_s = -1;
while ( n !=0 )
{
    n = Convert.ToInt32(Console.ReadLine());
    if (n > max_f)
    {
        max_s = max_f;
        max_f = n;
    }
    else if (n > max_s)
    {
        max_s = n;
    }
}
Console.WriteLine(max_s);
