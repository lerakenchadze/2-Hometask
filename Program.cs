// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int Test()
// {
//     int num = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine(num);
//     if (num>99 & num<1000)
//     {
//         int hund = num/100;
//         int ten = num / 10 % 10;
//         int one = num % 10;
//         return ((hund*10) + one);
//     }
//     else 
//         Console.WriteLine("Error");
//         return num;
// }

// Console.WriteLine("Введите трёхзначное число: ");
// int res = Test();
// Console.WriteLine(res);


// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// int Test()
// {
//     int num = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine(num);
//     while (num > 999)
//     {
//         int hund = num/10;
//         int ten = hund / 10 % 10;
//         int one = ten % 10;
//         return (one);
//     }
//     if (num > 99)
//     {
//         int one = num % 10;
//         return (one);
//     }
//     else
//     {
//         Console.WriteLine("Третьей цифры нет!");
//         return num;
//     }  

// }

// Console.WriteLine("Введите любое число: ");
// int res = Test();
// Console.WriteLine(res);


// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


// void Test(int num)
// {
//     if (num == 1)
//     {
//         Console.WriteLine("нет");
//     }
//     else if (num == 2)
//     {
//         Console.WriteLine("нет");
//     }
//     else if (num == 3)
//     {
//         Console.WriteLine("нет");
//     }
//     else if (num == 4)
//     {
//         Console.WriteLine("нет");
//     }
//     else if (num == 5)
//     {
//         Console.WriteLine("нет");
//     }
//     else if (num == 6)
//     {
//         Console.WriteLine("да");
//     }
//     else if (num == 7)
//     {
//         Console.WriteLine("да");
//     }
//     else
//     {
//         Console.WriteLine("Error!!! Введите число от 1 до 7");
//     }
// }

// Console.WriteLine("Введите номер дня недели: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Test(num);