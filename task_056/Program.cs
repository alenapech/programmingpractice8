/* Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.
*/

Console.WriteLine("Задача 056");
void Zadacha56()
{
    Random rand = new Random();
    int rows = rand.Next(2,5);
    int columns = rows + 1;
    int[,] array = new int[rows,columns];
    


FillArray(array);
PrintArray(array);

int min = Int32.MaxValue;
int result = 0;
for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum+=array[i,j];
                   
        }

        if (sum < min) 
        {
            
            min = sum;
            result = i;

        }

    }
    Console.WriteLine($"строка с минимальной суммой элементов: {result}");


}


Zadacha56();


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