Console.Clear();
int sum = 0;
int [] numbers = new int [4];
for (int i = 0; i < 4; i++)
    numbers [i] = new Random().Next(10,100);
Console.WriteLine(string.Join(",", numbers));
for (int i = 0; i < 4; i++)
    if (i%2 == 1)
        sum = sum + numbers[i];
Console.WriteLine($"Сумма нечётных позиций - {sum}");