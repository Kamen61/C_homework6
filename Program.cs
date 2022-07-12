// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// void NumberAboveZero(int size){
//     int[] arrayNumbers = new int[size];
//     int count=0;
//     for (int i=0;i<size;i++){
//         System.Console.WriteLine($"Введите число {i+1} (всего чисел должно быть {size})");
//         arrayNumbers[i]=Convert.ToInt32(Console.ReadLine());
//         if (arrayNumbers[i]>0)
//             count++;
//     }
//     System.Console.WriteLine("Количество положительных чисел {0} ",count);
// }


// NumberAboveZero(6);




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void IntersectionPoint(double b1,double k1, double b2, double k2){
    double x=0;
    double y=0;
    x = (b1-b2)/(k2-k1);
    y = (k2*b1-k1*b2)/(k2-k1);

    System.Console.WriteLine($"Точка пересения двух прямых -> ({x},{y})");
}
System.Console.Write("Введите значение b1 : ");
double enteredUserB1=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите значение k1 : ");
double enteredUserK1=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите значение b2 : ");
double enteredUserB2=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите значение k2 : ");
double enteredUserK2=Convert.ToDouble(Console.ReadLine());

IntersectionPoint(enteredUserB1,enteredUserK1,enteredUserB2,enteredUserK2);
