// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine("Введите количество строк двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] twoDimenArr = new int[m, n];
Random rand = new Random();
void PrintArray(int[,] arr) {
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) Console.Write($"{arr[i, j]} ");
        Console.WriteLine("");
    }}
void RandArray(int[,] arr) {
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) arr[i,j] = Convert.ToInt32(rand.Next(1, 1000)/10.0);
    }}
void average(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++) 
    {
        int srAr = 0;
        for (int t = 0; t < arr.GetLength(1); t++) srAr += arr[t, i];
        Console.WriteLine($"Cреднее арифметическое число столбца {i+1} = {(float)srAr/m}");
    }}
RandArray(twoDimenArr);
PrintArray(twoDimenArr);
average(twoDimenArr);