// See https://aka.ms/new-console-template for more information
int SumInNumber(int a, int length)
{
    if(length==1) return a;
    int sum = a/(int)Math.Pow(10, (length-1));
    return sum+SumInNumber(a%(int)Math.Pow(10, (length-1)), length-1);
}

Console.WriteLine("Введите число: ");
string m = Console.ReadLine();
int length = m.Length;
int a = Convert.ToInt32(m);

Console.WriteLine(SumInNumber(a, length));
