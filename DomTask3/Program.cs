// See https://aka.ms/new-console-template for more information
int A(int n, int m)
{
    if(n==0) return m+1;

    else if(n!=0 && m == 0) return A(n-1, 1);

    else return A(n-1, A(n, m-1));

}

Console.WriteLine(A(1,2));
Console.WriteLine(A(0,1));
Console.WriteLine(A(0,0));
Console.WriteLine(A(2,2));
Console.WriteLine(A(3,2));
Console.WriteLine(A(3,3));
Console.WriteLine(A(3,4));