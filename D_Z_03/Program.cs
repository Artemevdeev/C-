Console.WriteLine("Введите первое число: ");
string s_a = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string s_b = Console.ReadLine();
Console.WriteLine("Введите третье число: ");
string s_c = Console.ReadLine();

int a = int.Parse(s_a);
int b = int.Parse(s_b);
int c = int.Parse(s_c);

if (b > a)
{
     a = b;
if (c > a)
{
    a = c;
}
}
Console.Write(" Max  "   + a );


