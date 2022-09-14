Console.WriteLine("Введите x: ");
Console.Write("x = ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y: ");
Console.Write("y =  ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0)
    Console.WriteLine("1 ЧЕТВЕРТЬ");
else if (x < 0 && y > 0)
    Console.WriteLine("2 ЧЕТВЕРТЬ");
else if (x < 0 && y < 0)
    Console.WriteLine("3 ЧЕТВЕРТЬ");
else if (x > 0 && y < 0)
    Console.WriteLine("4 ЧЕТВЕРТЬ");
else 
    Console.WriteLine("Ошибка x и y не могут быть равны нулю по условию задачи!");
    