# lesson_7

#### Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
> m = 3, n = 4.

`Результат:`
`0,5 7 -2 -0,2`
`1 -3,3 8 -9,9`
`8 7,8 -7,1 9`

```csharp
Console.WriteLine("Введите количество строк двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] twoDimenArr = new double[m, n];
Random rand = new Random();
void PrintArray(double[,] arr) {
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) { Console.Write($"{arr[i, j]} "); }
        Console.WriteLine();
        }
    }

void RandArray(double[,] arr) {
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) { arr[i,j] = Convert.ToDouble(rand.Next(1, 1000)/10.0); }
        }
    }
	
RandArray(twoDimenArr);
PrintArray(twoDimenArr);
```

#### Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


> 1 4 7 2
5 9 2 3
8 4 2 4

`Результат: 17 -> такого числа в массиве нет`
```csharp
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
```

#### Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

> Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

`Результат: Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.`

```csharp
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
```


 
