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
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите коэффициент b1 ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите коэффициент k2 ");
    double k2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите коэффициент b2 ");
    double b2 = Convert.ToInt32(Console.ReadLine());

    // Формула для нахождения точки
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    //округляем до двух знаков
    x = Math.Round(x, 2);
    y = Math.Round(y ,2);

    Console.WriteLine($"Координаты точки {x} {y}");
}

pointIntescetionStraightLine();
