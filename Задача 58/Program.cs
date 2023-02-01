//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int n = 3;
int m = 3;
int k = 3;

int[][] matr1 = new int[n][]; //создаём первую матрицу
int[][] matr2 = new int[m][]; //....... вторую матрицу
int[][] result = new int[n][]; //...... результирующую
Random random = new Random();
for (int i = 0; i < result.Length; i++) result[i] = new int[k];

Console.WriteLine("Матрица № 1: ");
Console.WriteLine();
for (int i = 0; i < matr1.Length; i++)
{
    matr1[i] = new int[m];


    for (int j = 0; j < matr1[i].Length; j++)
    {
        matr1[i][j] = random.Next(1, 10);

        Console.Write(matr1[i][j] + "   ");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("Матрица № 2: ");

Console.WriteLine();
for (int i = 0; i < matr1.Length; i++)
{
    matr2[i] = new int[k];
    for (int j = 0; j < matr2[i].Length; j++)
    {
        matr2[i][j] = random.Next(1, 10);
        Console.Write(matr2[i][j] + "   ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < matr1.Length; i++)
{
    for (int j = 0; j < matr2[i].Length; j++)
    {
        for (int l = 0; l < matr2.Length; l++)
        {
            result[i][j] += matr1[i][l] * matr2[l][j];
        }
    }

}
Console.WriteLine("Результат: ");

Console.WriteLine();

for (int i = 0; i < result.Length; i++)
{
    for (int j = 0; j < result[i].Length; j++)
    {
        Console.Write(result[i][j] + "   ");
    }
    Console.WriteLine();
}

