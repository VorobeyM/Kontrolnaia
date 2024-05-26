using System;

class Program
{
    static void Main(string[] args)
    {
         Console.Write("Введите элементы массива через пробел: ");
        string[] initialArray = Console.ReadLine().Split(' ');
          string[] resultArray = CreateShortStringArray(initialArray);
          Console.WriteLine("Новый массив: [{0}]", string.Join(", ", resultArray));
    }

    static string[] CreateShortStringArray(string[] initialArray)
    {
         int shortStringCount = 0;
        foreach (string s in initialArray)
        {
            if (s.Length <= 3)
            {
                shortStringCount++;
            }
        }
          string[] resultArray = new string[shortStringCount];
        int index = 0;
        foreach (string s in initialArray)
        {
            if (s.Length <= 3)
            {
                resultArray[index++] = s;
            }
        }

        return resultArray;
    }
}

