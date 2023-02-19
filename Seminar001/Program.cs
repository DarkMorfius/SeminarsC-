//Console.Clear();
// int Num = 12;
// double BigNum = 12.13;
// bool get = true;
// string txt = " Text for Seminar";
// char symbol = '&';

// Console.WriteLine(txt + " " +get);
// Console.WriteLine($"Text for commit {Num} {BigNum} ");

// Console.WriteLine("Input your name");

// string username = Console.ReadLine();
// Console.WriteLine("Wow your name is " + username);
//      Это мы будем использовать постоянно
//              Console.Write("Imput an integer number: ");  
//              int num = Convert.ToInt32(Console.ReadLine());
//              Console.WriteLine("Your number is " + num);
//
//
//Шаблон заполнения ДЗ
// HomeWork1
//
// Task 1. Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом первого
// 

// Console.Write("Input a first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int quad2 = num2 * num2;

// if (num1 == quad2)
//     {

//         Console.WriteLine("Yes, this number is quad");

//     }
// else

//     {

//         Console.WriteLine("No, this number is not quad");

//     }

// Task 2. Напишите программу, которая на вход принмает одно число (N),
// А на выходе показывает все целые числа в промежутки от -N до N.
/*
Console.Write("Input a posivite nubmer: ");
int numposiv = Convert.ToInt32(Console.ReadLine());
int current = -numposiv;
while (current <= numposiv)
{

    Console.Write(current + " ");
    current++;

}
*/
// Избавление от младших разрядов
//31542/10 = 3154
//31542/100 = 315 
//31542/1000= 31
//Только младшие разряды
//31542 % 10 = 2
//31542 % 100 = 42
//31542 % 1000 =542

// 453216 -> 32 =