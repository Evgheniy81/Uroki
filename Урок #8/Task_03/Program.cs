//Напишите простой конвертер валют (без возможности динамаческого выбора валюты пользователем). 
//Валюты заданы хардкодом и не изменяются. Тип валют на выбор программиста.
/*
    double USD = 90.06;
    //double EUR = 101.20;
    Console.WriteLine("Введите количество внесенных рублей: ");
    string RUB = Console.ReadLine();
    int x = int.Parse(RUB);
    double result = x / USD;
    Console.WriteLine(result);
*/
{
double UsdToRub = 90.06;
double USD;

Console.WriteLine("Введите сумму в USD");

USD = double.Parse(Console.ReadLine());

Console.WriteLine(USD + " USD в RUB = " + USD * UsdToRub);
}