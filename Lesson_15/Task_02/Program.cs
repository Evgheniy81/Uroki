
//Создать калькулятор при помощь цикла if
// Мой вариант решения
/*
Console.WriteLine("Введите первое число: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите оператор действия: ");
string c = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
double b = double.Parse(Console.ReadLine());
double result = 0;
if (c == "+")
{
    Console.WriteLine(result = a + b);
}
if (c == "-")
{
    Console.WriteLine(result = a - b);
}
if (c == "*")
{
    Console.WriteLine(result = a * b);
}
if (c == "/")
{
    Console.WriteLine(result = a / b);
}
*/
//

while (true)
{
    double firstNumber, secondNumber;  // объявляем вещестенные переменные
    string action;  // объявляем строчную переменную операторов
    /*
    Console.WriteLine("Введите первое число: ");
    firstNumber = double.Parse(Console.ReadLine());  //конвертируем сразу из строки в вещественную переменную

    Console.WriteLine("Введите второе число: ");
    secondNumber = double.Parse(Console.ReadLine());  //конвертируем сразу из строки в вещественную переменную
    */
    // чтоб избежать введения неправильных данных используем следующий метод
    
    try
    {
        Console.WriteLine("Введите первое число: ");
        firstNumber = double.Parse(Console.ReadLine());  //конвертируем сразу из строки в вещественную переменную

        Console.WriteLine("Введите второе число: ");
        secondNumber = double.Parse(Console.ReadLine());  //конвертируем сразу из строки в вещественную переменную

    }
    catch (Exception)
    {
        Console.WriteLine("Не удалось преобразовать строку в число! Введите другое число");
        //Console.ReadLine();
        continue; // данная команда возращает обратно для введения правильных данных. Иначе программа попытается исполнить код ниже, но выдаст ошибку.
    }
    
    Console.WriteLine("Введите операцию: '+' '-' '*' '/' ");
    action = Console.ReadLine();  //задаем оператор

    if (action == "+") // через if и else проверяем введенный оператор и выполняем соответствующую операцию
    {
        Console.WriteLine(firstNumber + secondNumber);
    }
    else if (action == "-")
    {
        Console.WriteLine(firstNumber - secondNumber);
    }
    else if (action == "*")
    {
        Console.WriteLine(firstNumber * secondNumber);
    }
    else if (action == "/")
    {
        if (secondNumber == 0)  //проверяем введенное число на равенство нулю, если равно, то просив ввести др. число
        {
            Console.WriteLine("На нуль делить нельзя. Ведите другое число.");
        }
        else  // если нет, то выполняем действие
        {
            Console.WriteLine(firstNumber / secondNumber);
        }
    }
    else  // если введеный символ не равен ни одному из перечисленных операторов, то указываем на ошибку
    {
        Console.WriteLine("Ошибка! Введен неверный символ оператора!");
    }
    Console.ReadLine();
    Console.Clear();
}
