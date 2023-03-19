using System;

class Program
{
    static void Main()
    {
        // Ввод массива строк с клавиатуры
        string[] array1 = new string[5] { "123", "23", "hello", "world", "res" };


        // Создание нового массива строк
        string[] result = new string[array1.Length];
        int resultIndex = 0;
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i].Length <= 3)
            {
                result[resultIndex] = array1[i];
                resultIndex++;
            }
        }

        // Уменьшение размера массива до количества реально использованных элементов
        Array.Resize(ref result, resultIndex);

        // Вывод нового массива строк на экран
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }
    }
}
