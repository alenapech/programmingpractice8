/*Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива.
*/

Console.WriteLine("Задача 054");
void Zadacha54()
{
    Random rand = new Random();
    int rows = rand.Next(2,4);
    int columns = rand.Next(2,4);
    int[,] array = new int[rows,columns];
    


FillArray(array);
PrintArray(array);


for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
       for (int k = 0; k < array.GetLength(1); k++)
        {
            if (array[i,j] > array[i,k])
            {
                int temp = array[i,j];
                array[i,j] = array[i,k];
                array[i,k] = temp;
            }
        }
        }
    }
Console.WriteLine("Упорядоченный массив: ");
PrintArray(array);
}



Zadacha54();


void FillArray(int[,] currentArray)
    {Random rand = new Random();

        for (int i = 0; i < currentArray.GetLength(0); i++)
            {
            for (int j = 0; j < currentArray.GetLength(1); j++)
            {
            currentArray[i,j] = rand.Next(0,10);
            }
        
        }
    }

void PrintArray(int[,] currentArray)
    {
        Console.WriteLine();
        for (int i = 0; i < currentArray.GetLength(0); i++)
            {
            for (int j = 0; j < currentArray.GetLength(1); j++)
            {
            Console.Write(currentArray[i,j] +  "\t");
            }
             Console.WriteLine();
            }
    }