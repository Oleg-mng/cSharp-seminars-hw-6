// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

System.Console.WriteLine($"Задайте общее количество цифр для ввода");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Отлично. Вы задали количество цифр {m}");
System.Console.WriteLine($"Теперь пожалуйста задайте каждое число по очереди и положительные и отрицательные:");
int[] array = new int[m];
void Fillarraytom (int [] arr)
{
    for (int i = 0; i <m; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}
int Countpositivenumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < m; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
Fillarraytom(array);
int positive = Countpositivenumbers(array);
System.Console.WriteLine($"количество положительных чисел: {positive}");