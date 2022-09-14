Console.Write("Ведите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 99)
    Console.WriteLine("Третьей цифры нет");
else
    Console.WriteLine(Convert.ToString(n)[2]);

