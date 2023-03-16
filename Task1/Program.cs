// See https://aka.ms/new-console-template for more information
int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumbers(int m, int n)
{
    if(m>n) return;
    Console.Write(m + " ");
    PrintNumbers(m+1, n);
}


int m = Prompt("Введите первое число: ");
int n = Prompt("Введите второе число: ");

PrintNumbers(m,n);


