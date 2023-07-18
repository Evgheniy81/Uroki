//Создать два варианта калькулятора, который будет выполнять простые действия
//Мой вариант решения
/*
Console.WriteLine("Введите первое число: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите оператор действия: ");
string c = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
double b = double.Parse(Console.ReadLine());
double result = 0;  // можно данную переменную не вводить
switch (c)
{
    case "+":
        Console.WriteLine(result = a + b);
        break;
    case "-":
        Console.WriteLine(result = a - b);
        break;
    case "*":
        Console.WriteLine(result = a * b);
        break;
    case "/":
        Console.WriteLine(result = a / b);
        break;
        default:
        Console.WriteLine("Введен неизвесный символ!");
        break;
}
*/
////

double firstNumber, secondNumber;  // объявляем вещестенные переменные
string action;  // объявляем строчную переменную операторов
Console.WriteLine("Введите первое число: ");
firstNumber = double.Parse(Console.ReadLine());  //конвертируем сразу из строки в вещественную переменную
Console.WriteLine("Введите второе число: ");
secondNumber = double.Parse(Console.ReadLine());  //конвертируем сразу из строки в вещественную переменную
Console.WriteLine("Введите операцию: '+' '-' '*' '/' ");
action = Console.ReadLine();
switch (action)
{
    case "+":
        Console.WriteLine(firstNumber + secondNumber);
        break;
    case "-":
        Console.WriteLine(firstNumber - secondNumber);
        break;
    case "*":
        Console.WriteLine(firstNumber * secondNumber);
        break;
    case "/":   //так как на ноль делить нельзя прописываем об этом через цикл if
        if (secondNumber==0)    
            Console.WriteLine("На ноль делить нельзя. Ведите другое число.");
        else
            Console.WriteLine(firstNumber / secondNumber);
        break;
        default:  // если в action ввели неверный символ
        Console.WriteLine("Ошибка! Введен неверный символ!");  
        break;
}
