//Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
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