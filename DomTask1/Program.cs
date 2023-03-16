// See https://aka.ms/new-console-template for more information
int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumbers(int n)
{
    if(n==0) return;

    Console.Write(n + " ");
    PrintNumbers(n-1);
}


int n = Prompt("Введите число: ");

PrintNumbers(n);