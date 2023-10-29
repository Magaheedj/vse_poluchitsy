// Задача 7 HARD по желанию - идет за 2 обязательных Напишите программу, которая принимает на вход целое 
// число любой разрядности и на выходе показывает третью цифру слева этого числа или говорит, 
// что такой цифры нет. Через строку решать нельзя.
// Console.Clear();
// System.Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());
// string str1 = Convert.ToString(n);
// void SizeSumValue(string  sttt)
// {
//     for (int i = 0; i < sttt.Length; i ++)
//     {
//        System.Console.WriteLine(i);
//     }
// }
// SizeSumValue(str1);




/*
Ассистент
Конечно, вот 10 задач для начинающих C# разработчиков, чтобы попрактиковаться и улучшить свои навыки:

Привет, мир!: Создайте консольное приложение, которое выводит на экран фразу "Hello, World!".

Калькулятор: Напишите программу, которая запрашивает два числа у пользователя и выполняет математические операции с ними (сложение, вычитание, умножение, деление).

Генератор случайных чисел: Создайте программу, которая генерирует случайное число от 1 до 100 и предлагает пользователю отгадать это число.

Конвертер единиц: Напишите конвертер для перевода температуры из градусов Цельсия в градусы Фаренгейта и наоборот.

Подсчет факториала: Напишите программу, которая запрашивает у пользователя число и вычисляет его факториал.

Поиск простых чисел: Создайте программу, которая находит все простые числа в заданном диапазоне.

Работа с массивами: Напишите программу, которая находит среднее значение элементов в массиве целых чисел.

Реверс строки: Напишите функцию, которая принимает строку и возвращает ее в обратном порядке.

Подсчет гласных: Создайте программу, которая считает количество гласных букв в введенной пользователем строке.

Игра в "Камень, ножницы, бумага": Напишите игру для одного игрока, где он выбирает один из трех вариантов, а компьютер также выбирает и объявляется результат.

Эти задачи предоставляют отличные возможности для практики основных концепций языка C# и программирования в целом.
*/


// int Prompt(string msg)
// {

// System.Console.WriteLine($"{msg}");
// return Convert.ToInt32(Console.ReadLine());
// }
// int number = Prompt("Введите число");

// int fnumber(int number)
// {
// while (number > 9999)
// {
// number /= 10;
// }
// return number % 10;
// }

// bool check(int number)
// {
// if (number < 1000)
// return false;
// else return true;
// }

// if (check(number) != true)
// System.Console.WriteLine("Четвертой цифры нет");
// else
// System.Console.WriteLine($"Четвертой цифра числа {number} является {fnumber(number)}");

// Генератор случайных чисел: Создайте программу, которая генерирует случайное число от 1 до 100 
// и предлагает пользователю отгадать это число.
// Console.Clear();
// Random random = new Random();
//         int targetNumber = random.Next(1, 101);
//         int guess;

//         do
//         {
//             Console.Write("Попробуйте угадать число от 1 до 100: ");
//             guess = Convert.ToInt32(Console.ReadLine());

//             if (guess < targetNumber)
//                 Console.WriteLine("Больше");
//             else if (guess > targetNumber)
//                 Console.WriteLine("Меньше");
//             else
//                 Console.WriteLine("Правильно!");
//         } while (guess != targetNumber);





// System.Console.WriteLine($"{7},  {15},  {100}");
// int value = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine("Вот  какок число вы вели  " + value);

// System.Console.WriteLine("Ведите количестово рандомных чисел ");
// int p = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine("Введите Верхнюю границу мах числа ");
// int num = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine("Введите Нижнююнюю границу мах числа ");
// int kost = int.Parse(Console.ReadLine()!);
// Console.Clear();
// void ValueRAndom(int n)
// {
// Random value = new Random();
// for ( int i = 0; i < n; i++ )
// {
// Console.WriteLine(value.Next(kost,num));
// }
// } 
// ValueRAndom(p);

