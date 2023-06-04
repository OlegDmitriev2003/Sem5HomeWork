Console.Clear();
int count = 0;
int [] numbers = new int [4];
for (int i = 0 ; i < 4; i++)
    numbers [i] = new Random().Next(100,1000);
Console.WriteLine (string.Join(",", numbers));
for (int i = 0 ; i < 4; i++)
    if (numbers[i] % 2 == 0)
        count++;
Console.WriteLine($"Чётных чисел - {count}");