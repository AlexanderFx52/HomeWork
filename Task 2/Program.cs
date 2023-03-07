Console.Clear();
Console.Write("Введите первое число ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число ");
int с = int.Parse(Console.ReadLine()!);

int max = 0;

if(max < a)
    max = a;
if(max < b)
    max = b;
if(max < с)
    max = с;
Console.Write("Максимальное число = ");
Console.Write(max);

