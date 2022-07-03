//принимает на вход число и выдает  количество цифр

//первый вариант
System.Console.WriteLine("Введите число1:");
int num = int.Parse(Console.ReadLine());

int count = 0;
for (; num != 0; num /= 10)
{
    count++;
}
System.Console.WriteLine(count);

//второй вариант через логарифм
System.Console.WriteLine("Введите число2:");
int num1 = int.Parse(Console.ReadLine());

System.Console.WriteLine((int) Math.Log10(num1) + 1);