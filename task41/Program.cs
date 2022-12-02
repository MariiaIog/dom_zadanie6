/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int M = new int();
Console.WriteLine("Введите количество чисел, с которыми вы хотите работать:");
M = Convert.ToInt32(Console.ReadLine());

int[] array = new int[M];
int i = 0;
while (i < M)
{
    Console.WriteLine("Введите число:");
    array[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}

int NumberOfPositiveElement(int[] element)
{
    int count = 0;
    int length = element.Length;
    for (int index = 0; index < length; index++)
    {
        if (element[index] > 0)
        {
            count++;
        }
    }
    return count;
}

int count = NumberOfPositiveElement(array);
/*Console.WriteLine();*/
Console.WriteLine($"Количество положительных введенных чисел равно {count}");
