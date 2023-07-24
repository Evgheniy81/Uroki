// Найдите количество четных и нечетных чисел в указанном диапазоне
/////Мой вариант
/*
int a = 1;
int count1 = 0;
int count2 = 0;
int limit = int.Parse(Console.ReadLine());
while (a <= limit)
{
    if (a % 2 == 0)
    {
        count1++;
    }
    else
    {
        count2++;
    }
    a++;
}
Console.WriteLine("Количество четных чисел:" + count1);
Console.WriteLine("Количество нечетных чисел:" + count2);
*/
/////
// Найдите количество и суммы четных и нечетных чисел в указанном диапазоне

uint oddNumbersCount = 0;  // нечётные числа вводим в данной переменной, так как результат будет только положительным
uint evenNumbersCount = 0;  // чётные числа вводим в данной переменной, так как результат будет только положительным
int oddNumbersSum = 0;  // Сумма нечётные числа
int evenNumbersSum = 0;  // Сумма чётные числа

Console.WriteLine("Введите первое число диапозона");
int currentValue = int.Parse(Console.ReadLine());
Console.WriteLine("Введите последнее число диапозона");
int limit = int.Parse(Console.ReadLine());
while (currentValue <= limit)
{
    if (currentValue % 2 == 0)
    {
        //evenNumbersSum = evenNumbersSum + currentValue; // длиная запись
        evenNumbersSum += currentValue;  // коротка запись
        evenNumbersCount++;
    }
    else
    {
        oddNumbersSum = oddNumbersSum + currentValue;  // длиная запись
        //oddNumbersSum += currentValue;  // коротка запись
        oddNumbersCount++;
    }
    currentValue++;
}
Console.WriteLine("Количество чётных чисел: " + evenNumbersCount);
Console.WriteLine("Количество нечётных чисел: " + oddNumbersCount);
Console.WriteLine("Сумма чётных чисел: " + evenNumbersSum);
Console.WriteLine("Сумма нечётных чисел: " + oddNumbersSum);
