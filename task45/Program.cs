// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
Main();

void Main()
{
    int num1 = EnterNumber();
    int[] array1 = new int[num1];
    FillArray(array1);
    PrintArray(array1);
    int[] array2 = CopyArray(array1);
    PrintArray(array2);
}

int EnterNumber()
            {
                Console.Write("Введите число: ");
                return int.Parse(Console.ReadLine());
            }

void FillArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new Random().Next(- array.Length, array.Length);
                }
            }

void PrintArray(int[] array)
            {
                foreach (int el in array)
                {
                    Console.Write($"{el} ");
                }
                Console.WriteLine();
            }

int[] CopyArray(int[] array)
{
    //int size = array.Length();
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}