Console.WriteLine("Введите число");
string a = Console.ReadLine();
int b = int.Parse(a);
int c = 2;

while (c<b+1)
{
    Console.Write($"{c} ");
    c=c+2;
}

