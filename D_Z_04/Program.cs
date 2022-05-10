Console.WriteLine("Введите число");
string s = Console.ReadLine();
int num = int.Parse(s);

if(num%2==0)
{
    Console.Write("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}