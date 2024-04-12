//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []
using System;
class Geeks{

public static void Main() 
{

String[] string_array1 = new String[10] {"Monday", "Tue", "Wed", "Thu", "Fri", "Saturday", "Sunday", "Pizza Day", "Catt", "Garbage Day"};
Console.WriteLine(String.Join(", ", string_array1));
string[] string_array2 = new string[string_array1.Length];
var counter = 0;
for (int i = 0; i < string_array1.Length; i++)
{   
    if (string_array1[i].Length < 4)
    {
        string_array2[counter++] = string_array1[i];
        Console.Write($"{string_array1[i]}" + " ");
    }
}
}
}