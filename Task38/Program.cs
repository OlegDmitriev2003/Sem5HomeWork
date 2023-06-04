Console.Clear();
int begin = 100;
int end = 10;
double max = 0;
double min = 100;
double [] numbers = new double [5];
for(int i = 0; i < 5; i++)
    numbers[i] = Math.Round(new Random().NextDouble()*(end-begin)+begin, 2);
Console.WriteLine(string.Join(", ", numbers));
for(int i = 0; i < 5; i++)
    if (numbers[i]>max)
        max = numbers[i];
for(int i = 0; i < 5; i++)
    if (numbers[i]<min)
        min = numbers[i];
Console.WriteLine($"Сумма минимального и максимального значений - {min+max}");