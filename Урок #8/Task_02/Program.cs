
//Введите три числа и выведите на экран значение суммы и произведения этих чисел.

double firstValue, secondValue, thirdValue;
Console.WriteLine("Введите число 1");
firstValue = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2");
secondValue = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число 3");
thirdValue = double.Parse(Console.ReadLine());
double sumResult = (firstValue + secondValue + thirdValue);
double multResult = firstValue * secondValue * thirdValue;
Console.WriteLine("Cумма трех чисел = " + sumResult);
Console.WriteLine("Произведение трех чисел = " + multResult);