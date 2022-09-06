Console.Write("Üçgenin uzunluğunu girin: ");
int uzunluk = Convert.ToInt32(Console.ReadLine());
Console.Clear();

for (int i = 1; i <= uzunluk; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.Read();