Console.Write("Nhap n = ");
int n = int.Parse(Console.ReadLine());
List<int> Day_so = new List<int>();
for (int i = 0; i < n; i++)
{
    int m = int.Parse(Console.ReadLine());
    Day_so.Add(m);
}
for (int i = 0; i < n; i++)
{
    for (int j = i + 1; j < n; j++)
    {
        if (Day_so[i] > Day_so[j])
        {
            int tam = Day_so[i];
            Day_so[i] = Day_so[j];
            Day_so[j] = tam;
        }
    }
}
Console.Write("Sap xep tang dan: ");
foreach (var x in Day_so)
{
    Console.Write(x + " ");
}