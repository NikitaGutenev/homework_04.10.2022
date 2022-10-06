// // первая задача

// Console.WriteLine("введите трехзначное число: ");
// int num1 = int.Parse(Console.ReadLine()!);
// int a = num1/10%10;
// Console.WriteLine(a);



// // вторая задача

// Console.WriteLine("введите число: ");
// int num1 = int.Parse(Console.ReadLine()!);
// int a = num1/100;
// if (a == 0)
// {
//     Console.WriteLine("третьей цифры нет");
// }
// else{
//     a = a%10;
//     Console.WriteLine(a);
// }



// // третья задача

// Console.WriteLine("введите цифру обозначающую день недели: ");
// int num1 = int.Parse(Console.ReadLine()!);

// if (num1 < 1 || num1 > 7)
// {
//     Console.WriteLine("Ошбика! Введите число включительно от 1 до 7");
// }
// else
// {
//     if (num1 < 6)
//     {
//         Console.WriteLine("Этот день не выходной");
//     }
//     else
//     {
//         Console.WriteLine("Урааааа! Выходной!");
//     }
// }