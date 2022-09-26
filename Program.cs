//Задача 7   (0,7,7) (0,139,139) (146,222,76)

Console.WriteLine("Введите два числа типа byte");
byte First = byte.Parse(Console.ReadLine());
byte Second = byte.Parse(Console.ReadLine());
Console.WriteLine("Побитовое И чисел:" + (First & Second));
Console.WriteLine("Побитовое ИЛИ чисел:" + (First | Second));
Console.WriteLine("Побитовое исключающее ИЛИ чисел:" + (First ^ Second));