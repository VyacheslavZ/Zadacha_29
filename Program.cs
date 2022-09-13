Console.WriteLine("Укажите размер массива - " );
int count = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[count];
for (int i = 0; i < count; i++)
    {
    Console.WriteLine($"Введите элемент массива с индексом {i} - ");
    mass[i] = Convert.ToInt32(Console.ReadLine());
    } 
Console.WriteLine($"Ваш массив: [{String.Join(",", mass)}]");
