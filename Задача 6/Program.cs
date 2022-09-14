Console.WriteLine("Введите N: ");
Console.Write("N = ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= N)
{
    Console.Write(Math.Pow(i,2) + ", ");
    i++;
}