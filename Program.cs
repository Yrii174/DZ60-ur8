/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/
Console.WriteLine($"Введите размер массива X x Y x Z: ");
int x = Numbers("Введите X: ");
int y = Numbers("Введите Y: ");
int z = Numbers("Введите Z: ");
Console.WriteLine($"");

int Numbers(string ii)
{
  Console.Write(ii);
  int nn = Convert.ToInt32(Console.ReadLine());
  return nn;
}

void WriteArray (int[,,] Array3)
{
  for (int i = 0; i < Array3.GetLength(0); i++)
  {
    for (int j = 0; j < Array3.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < Array3.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={Array3[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] Array3)
{
  int[] temp = new int[Array3.GetLength(0) * Array3.GetLength(1) * Array3.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < Array3.GetLength(0); x++)
  {
    for (int y = 0; y < Array3.GetLength(1); y++)
    {
      for (int z = 0; z < Array3.GetLength(2); z++)
      {
        Array3[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

int[,,] Array3 = new int[x, y, z];
CreateArray(Array3);
WriteArray(Array3);