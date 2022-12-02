// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// void quantity_0_numberInUsersString ()
// {
//     int counter = 0;
//     Console.WriteLine("Введите строку ");
//     string text = Console.ReadLine();

//     for (int i = 0; i < text.Length; i++)
//     {
//         if (text[i] == '0') 
//         {
//             Console.WriteLine($"Ноль находиться на позиции {i + 1}");
//             counter++;
//         }
//     }
//     Console.WriteLine($"Кол-во нулей в строке: {counter}");
// }


// quantity_0_numberInUsersString();


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void pointIntescetionStraightLine()
{
    // Пользовательский ввод данных прямых линий
    Console.WriteLine("Введите коэффициент k1 ");
    int k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите коэффициент b1 ");
    int b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите коэффициент k2 ");
    int k2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите коэффициент b2 ");
    int b2 = Convert.ToInt32(Console.ReadLine());

    // Решение системы из двух уравнений
    // y = k1 * x + b1
    // y = k2 * x + b2

    int x; int y; // Координаты точки пересечения прямых
    
    y = k1 * (b1 - y)/k1 + b1;

    Console.WriteLine($"Координаты точки {x} {y}");

}

pointIntescetionStraightLine();
