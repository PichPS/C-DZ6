// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] EnterArr()
{
    System.Console.WriteLine("Введите количество элементов массива");
    int n = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите меньшее число массива");
    int a = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите большее число массива");
    int b = Convert.ToInt32(Console.ReadLine());
    int[] Rand = new int[n];
    for (int i = 0; i < Rand.Length; i++)
    {
        Rand[i] = new Random().Next(a, (b + 1));
    }
    System.Console.Write($"[{string.Join(", ", Rand)}] -> ");
    return Rand;
}
int Count (int[] Arr)
{
    int c = Arr[0];
    for (int i = 0; i < Arr.Length; i++)
    {
        if (Arr[i] > c) c = c + 1;
        
    }

    System.Console.WriteLine(c);
    return c;  
}
Count(EnterArr());
