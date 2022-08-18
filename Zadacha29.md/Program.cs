// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

void Zadacha29()
{

int size = 8;
int[] array = new int[size];
array = FillArr(size);
PrintArray(array);
}

int[] FillArr(int size)
{
      
      int[] FillArray = new int[size];
      Random random = new Random();
      for(int i = 0; i < FillArray.Length; i++)
      {
            FillArray[i] = random.Next(1, 100);
      }
      return FillArray;
}

void PrintArray(int[] array)
{
      Console.WriteLine("Вывод массива");
      Console.Write("[");
      for(int i = 0; i < array.Length; i++)
      {
            Console.Write(array[i] + " ");
      }
      Console.Write("]");
      Console.WriteLine();
}
Zadacha29();