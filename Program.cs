// Собираем набор методов вместе

// using System;

// class NumberUtils
// {
//     public static bool IsPrime(int number)
//     {
//         if (number < 2)
//         {
//             return false;
//         }

//         for (int i = 2; i < number; i++)
//         {
//             if (number % i == 0)
//             {
//                 return false;
//             }
//         }

//         return true;
//     }

//     public static int FindMax(int a, int b, int c)
//     {
//         int max = a;

//         if (b > max)
//         {
//             max = b;
//         }

//         if (c > max)
//         {
//             max = c;
//         }

//         return max;
//     }

//     public static double CalculateAverage(int a, int b, int c)
//     {
//         return (a + b + c) / 3.0;
//     }

//     public static void PrintSeparator()
//     {
//         Console.WriteLine(new string('-', 40));
//     }

//     static void Main()
//     {
//         int num1 = ReadInt("Введите первое число: ");
//         int num2 = ReadInt("Введите второе число: ");
//         int num3 = ReadInt("Введите третье число: ");

//         PrintSeparator();

//         Console.WriteLine($"{num1} простое: {IsPrime(num1)}");
//         Console.WriteLine($"{num2} простое: {IsPrime(num2)}");
//         Console.WriteLine($"{num3} простое: {IsPrime(num3)}");

//         Console.WriteLine($"2 простое: {IsPrime(2)}");
//         Console.WriteLine($"1 простое: {IsPrime(1)}");

//         PrintSeparator();

//         Console.WriteLine($"Максимум из трёх: {FindMax(num1, num2, num3)}");
//         Console.WriteLine($"Максимум (другой порядок аргументов): {FindMax(num3, num1, num2)}");
//         Console.WriteLine($"Максимум из 5, 10, 3: {FindMax(5, 10, 3)}");

//         PrintSeparator();

//         double average = CalculateAverage(num1, num2, num3);
//         Console.WriteLine($"Среднее арифметическое: {average:F2}");

//         PrintSeparator();
//     }

//     private static int ReadInt(string prompt)
//     {
//         while (true)
//         {
//             Console.Write(prompt);
//             string? input = Console.ReadLine();

//             if (int.TryParse(input, out int result))
//             {
//                 return result;
//             }
//         }
//     }
// }


// ### Задание 1. Конвертер единиц ★

// Console.WriteLine();

// Console.WriteLine($"5 м = {MetersToFeet(5):F2} футов");
// Console.WriteLine($"10 м = {MetersToFeet(10):F2} футов");

// Console.WriteLine($"0°C = {CelsiusToFahrenheit(0):F2}°F");
// Console.WriteLine($"100°C = {CelsiusToFahrenheit(100):F2}°F");
// Console.WriteLine($"37°C = {CelsiusToFahrenheit(37):F2}°F");

// double MetersToFeet(double meters) {
//     return meters * 3.28084;
// }

// double CelsiusToFahrenheit(double celsius) {
//     return celsius * 9.0 / 5.0 + 32.0;
// }


// // 
// ### Задание 2. Валидатор с вложенными методами ★★★

bool HasMinLength(string password, int minLength) {
    return password.Length >= minLength;
}

bool HasDigit(string password) {
    foreach (char letter in password) {
        if (char.IsDigit(letter)) {
            return true;
        }
    }
    return false;
}

bool HasUpperCase(string password) {
    foreach (char letter in password) {
        if (char.IsUpper(letter)) {
            return true;
        }
    }
    return false;
}

bool IsPasswordValid(string password)
{
    return HasMinLength(password, 8) && HasDigit(password) && HasUpperCase(password);
}
Console.Write("Введите пароль: ");
string? password = Console.ReadLine() ?? "";

Console.WriteLine();
Console.WriteLine($"Пароль подходит: {IsPasswordValid(password)}");
Console.WriteLine();
Console.WriteLine("Детали проверки:");
Console.WriteLine($"  Длина не менее 8: {HasMinLength(password, 8)}");
Console.WriteLine($"  Содержит цифру:  {HasDigit(password)}");
Console.WriteLine($"  Содержит заглавную букву: {HasUpperCase(password)}");