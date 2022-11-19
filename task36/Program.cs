/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
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
void SumOfOddElements(int[] array)
{
int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        sum = sum + array[i];
        i++;
    }
    System.Console.WriteLine(sum);
}
int[] array = GenerateArray(4, -5, 10);
PrintArray(array);
SumOfOddElements(array);
System.Console.WriteLine();

