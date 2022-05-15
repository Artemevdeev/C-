
string str = Console.ReadLine();
int i = int.Parse(str);

void ThirdNum(int num){
    if(num > 99)
    {
    while (num>999)
    {
        num = num / 10;
    }
    num = num % 10;
    Console.WriteLine(num);
    }
    else{
        Console.WriteLine("There is no third number!");
    }
}

ThirdNum(i);

