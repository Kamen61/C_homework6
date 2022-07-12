﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void NumberAboveZero(int size){
    int[] arrayNumbers = new int[size];
    int count=0;
    for (int i=0;i<size;i++){
        System.Console.WriteLine($"Введите число {i+1} (всего чисел должно быть {size})");
        arrayNumbers[i]=Convert.ToInt32(Console.ReadLine());
        if (arrayNumbers[i]>0)
            count++;
    }
    System.Console.WriteLine("Количество положительных чисел {0} из введеных вами",count);
}


NumberAboveZero(6);




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)