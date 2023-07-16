// Найти среднее арифметическое двух чисел.


double firstValue, secondValue;
Console.WriteLine("Введите число 1");
firstValue = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2");
secondValue = double.Parse(Console.ReadLine());
double result = (firstValue + secondValue) / 2;
Console.WriteLine("Cреднее арифметическое двух чисел = " + result);


