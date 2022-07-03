//принимает число N и выдает произведение от 1 до N

System.Console.WriteLine("Введите число:");
int N = int.Parse(Console.ReadLine());

int Factorial = 1;
int n = 1;

while (n <= N)
{
    Factorial = n * Factorial;
    n++;
}
Console.WriteLine(Factorial);