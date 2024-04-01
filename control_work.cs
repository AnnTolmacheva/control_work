//          Задача:
// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомндуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.
//         Решение:

using System;

class Program
{
    static void Main(string[] args)
    {
        // Пример ввода массива строк с клавиатуры
        Console.WriteLine("Введите элементы массива через запятую:");
        string input = Console.ReadLine();
        string[] originalArray = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

        // Вызов метода для формирования нового массива
        string[] resultArray = FilterStrings(originalArray);

        // Вывод нового массива
        Console.WriteLine("Новый массив:");
        foreach (string str in resultArray)
        {
            Console.WriteLine(str);
        }
    }

    static string[] FilterStrings(string[] array)
    {
        // Подсчет количества строк, удовлетворяющих условию
        int count = 0;
        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создание нового массива нужного размера
        string[] result = new string[count];

        // Заполнение нового массива
        int index = 0;
        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                result[index] = str;
                index++;
            }
        }

        return result;
    }
}