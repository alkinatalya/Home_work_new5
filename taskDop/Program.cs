/*Дополнительно. Дан массив чисел. Напишите функцию, которая ищет 
заданное число в массиве и показывает нужный индекс в нем. При 
отсутствии числа возвращать -1.*/
int[] GenerateArray(int length, int minRandom, int maxRandom)
{
    Random rnd = new Random();
    int[] answer = new int[length];
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(minRandom, maxRandom + 1);
    }
    return answer;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "\t");
    }
    System.Console.WriteLine();
}
void NumberSearch(int[] array, int number)
{
    int index = -1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            index = i;
            Console.WriteLine($" Индекс числа в массиве: {index}");
        }
    }
    if (index == -1)
    {
        Console.WriteLine($" Индекс числа в массиве: {index}");
    }
}
int[] array = GenerateArray(5, 1, 10);
PrintArray(array);
Console.WriteLine("Введите число от 1 до 10: ");
int number = int.Parse(Console.ReadLine()!);
NumberSearch(array, number);