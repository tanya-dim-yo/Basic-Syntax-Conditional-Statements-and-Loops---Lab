int n = int.Parse(Console.ReadLine());
int a;
int sum = 0;

for (int i = 0; i < n; i++)
{
    a = 1 + i * 2;
    Console.WriteLine(" " + a);
    sum += a;
}

Console.WriteLine($"Sum: {sum}");