// Task 29

Console.WriteLine("Введите количество элементов массива: ");
int [] array = new int[Convert.ToInt32(Console.ReadLine())];
int i = 0;
while (i < array.Length)
{
    array[i] = new Random().Next(1, 100);
    Console.WriteLine($"Элемент массива № {i} = {array[i]}");
    i++;
}