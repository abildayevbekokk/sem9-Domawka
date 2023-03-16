// See https://aka.ms/new-console-template for more information
int SumNumbers(int m, int n)
{ 
    int sum = 0;
    sum += m;

    if(m>n) return 0;

    return sum + SumNumbers(m+1, n);
}

int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = Prompt("Введите первое число: ");
int n = Prompt("Введите второе число: ");

int sum = SumNumbers(m, n);
Console.WriteLine($"Сумма чисел = {sum}");