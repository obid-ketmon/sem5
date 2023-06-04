//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет
// количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

  /*      int[] array = new int[4]; // Создание массива из 4 элементов

        Random random = new Random();

        // Заполнение массива случайными положительными трехзначными числами
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(100, 1000);
        }

        // Вывод элементов массива на экран
        Console.WriteLine("Массив:");
        foreach (int element in array)
        {
            Console.WriteLine(element);
        }

        // Подсчет количества четных чисел в массиве
        int countEven = 0;
        foreach (int element in array)
        {
            if (element % 2 == 0)
            {
                countEven++;
            }
        }

        Console.WriteLine("Количество четных чисел в массиве: " + countEven);*/
        
//  Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0       
 
/*int[] array = new int[4]; // Создание массива из 4 элементов
        Random random = new Random();

        // Заполнение массива случайными числами
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-100, 100);
        }

        // Вывод элементов массива на экран
        Console.WriteLine("Элементы массива:");
        foreach (int element in array)
        {
            Console.WriteLine(element);
        }

        // Нахождение суммы элементов на нечетных позициях
        int sum = 0;
        for (int i = 1; i < array.Length; i += 2)
        {
            sum += array[i];
        }
Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

 /*double[] array = { 3.22, 4.2, 1.15, 77.15, 65.2 }; // Задание массива вещественных чисел

        // Вывод элементов массива на экран
    Console.WriteLine("Элементы массива:");
        foreach (double element in array)
        {
            Console.WriteLine(element);
        }

        // Нахождение минимального и максимального элементов
    double min = array[0];
    double max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        // Вычисление разницы между максимальным и минимальным элементами
    double difference = max - min;

Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference); */
