// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("Введите количество строк двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] twoDimenArr = new int[m, n];
Random rand = new Random();
void PrintArray(int[,] arr) {
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            Console.Write($"{arr[i, j]} "); 
            }
        Console.WriteLine();
        }}
void NumInArray(int[,] arr) {
    int isnum = 0;
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    foreach (int i in arr) if (i == num) isnum = 1;
    if (isnum == 1) Console.Write($"{num} -> присутствует в мессиве");
    else Console.Write($"{num} -> такого числа в массиве нет");
}
void RandArray(int[,] arr) {
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) { arr[i,j] = Convert.ToInt32(rand.Next(1, 1000)/10.0); }
    }}
RandArray(twoDimenArr);
PrintArray(twoDimenArr);
NumInArray(twoDimenArr);
