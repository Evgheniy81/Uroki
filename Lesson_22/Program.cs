//цикл в цикле
/*
for (int i = 1; i <= 3; i++)
{
    Console.WriteLine("цикл 1 итерация №: " + i);
    for (int j = 1; j <= 3; j++)
    {
        Console.WriteLine("\t цикл 2 итерация №: " + j); //табуляция нужна для того чтобы был отступ между циклами
        for (int k = 1; k <= 2; k++)
        {
            Console.WriteLine("\t\t цикл 3 итерация №: " + k);
        }
    }
}
*/
//рисуем прямоугольник в консоле
/*
Console.Write("Введите высоту прямоугольника: ");
int heigth = int.Parse(Console.ReadLine());

Console.Write("Введите ширину прямоугольника: ");
int width = int.Parse(Console.ReadLine());

for (int i = 0; i < heigth; i++)
{
    Console.Write(i + " ");
    for (int j = 0; j < width; j++)
    {
        Console.Write("#");
    }
    Console.WriteLine();
}
*/

//Рисуем триугольники в консоли без if и else
Console.Write("Введите высоту треугольника: ");
int heigth = int.Parse(Console.ReadLine());

for (int i = 0; i < heigth; i++)
{
    Console.Write(i + " ");
    for (int j = 0; j <= i; j++)  //+
    {                             //++
        Console.Write("+");       //+++
    }                             //++++
    Console.WriteLine();          //+++++
}
Console.WriteLine();

for (int i = 0; i < heigth; i++)
{
    Console.Write(i + " ");
    for (int j = heigth; j > i; j--)    //-----
    {                                   //----
        Console.Write("-");             //---
    }                                   //--
    Console.WriteLine();                //-
}
Console.WriteLine();
for (int i = 0; i < heigth; i++)
{
    Console.Write(i + " ");
    for (int j = heigth; j > i; j--)
    {
        Console.Write(" ");
    }
    for (int j = 0; j <= i; j++)
    {
        Console.Write("#");
    }
    Console.WriteLine();
}

/* //мой вариант
Console.WriteLine();
for (int i = 0; i < 10; i++)
{
    int j = 0;                      //    *
    Console.Write(i + " ");         //   **
    for (; j < 9 - i; j++)          //  ***
    {                               // ****
        Console.Write(" ");         //*****
    }
    for (; j < 10; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
*/
Console.WriteLine();
for (int i = 0; i < heigth; i++)
{
    Console.Write(i + " ");
    for (int j = 0; j <= i; j++)
    {
        Console.Write(" ");
    }
    for (int j = heigth; j > i; j--)
    {
        Console.Write("#");
    }
    Console.WriteLine();
}
Console.WriteLine();
/* //мой вариант
for (int i = 0; i < 10; i++)
{
    int j = 9;                      //#####
    Console.Write(i + " ");         // ####
    for (; j > 9 - i; j--)          //  ###
    {                               //   ##
        Console.Write(" ");         //    #
    }
    for (; j >= 0; j--)
    {
        Console.Write("#");
    }
    Console.WriteLine();
}
*/