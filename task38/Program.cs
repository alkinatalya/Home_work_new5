/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/
double[] GenerateArray(int length, int minRandom, int maxRandom)
{
    Random rnd = new Random();
    double[] answer = new double[length];
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(minRandom, maxRandom) + rnd.NextDouble();
    }
    return answer;
}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "\t");
    }
    System.Console.WriteLine();
}
double DifferenceMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    double difference = max - min;
return difference;
}
double[] array = GenerateArray(4, 100, 1000);
PrintArray(array);
System.Console.WriteLine($" Разница между максимальным и минимальным элементом массива:{DifferenceMaxMin(array)}");