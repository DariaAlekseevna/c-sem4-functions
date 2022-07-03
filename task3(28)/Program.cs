//принимает число N и выдает произведение от 1 до N

System.Console.WriteLine("Введите число:");
int N = int.Parse(Console.ReadLine());

int Factorial = 1;
int n = 1;

while (n <= N)
{
    Factorial *= n;
    n++;
}
Console.WriteLine(Factorial);

//через функцию

System.Console.WriteLine("Введите число:");
int N1 = int.Parse(Console.ReadLine());
Console.WriteLine(FACTORIAL(N1));

int FACTORIAL(int N1)
{
    int Factorial1 = 1;
    int n1 = 1;

    while (n1 <= N1)
    {
        Factorial1 *= n1;
        n1++;
    }
    return Factorial1;
}


