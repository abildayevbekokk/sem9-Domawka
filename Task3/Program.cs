// See https://aka.ms/new-console-template for more information
int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int NumberPow(int a, int b)
{
    if(b==0) return 1;

    return a*NumberPow(a,b-1);
}

int a = Prompt("Введите число: ");
int b = Prompt("Введите степень: ");

Console.WriteLine(NumberPow(a,b));
