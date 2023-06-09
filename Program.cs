﻿string[] arr_1 = {"Hello", "2", "world", ":-)"};
string[] arr_2 = {"1234", "1567", "-2", "computer science"};
string[] arr_3 = {"Russia", "Denmark", "Kazan"};

string[] ThreeAndUnder(string[] arr)
{
    int iter = 0;
    foreach (var item in arr) //считаем сколько вхождений элеменотов массива с количеством символов 3 и меньше
    {
        if (item.Length <= 3)
        {
            iter++;
        }
    }

    string[] myArr; //массив куда попадут элементы с количеством символов 3 и меньше

    if (iter <= 0) //если элементов с количеством символов 3 и меньше нет, создаём пустой массив myArr
    {
        return myArr = new string[] {}; 
    }
    else //если элементы с количеством символов 3 и меньше есть, заполняем массив myArr ими
    {
        myArr = new string[iter];
        iter = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                myArr[iter] = arr[i];
                iter++;
            }            
        }
        return myArr;
    }
}

void PrintTwoArrays(string[] originalArr, string[] editedArr)
{
    Console.Write("[");

    for (int i = 0; i < originalArr.Length; i++)
    {
        Console.Write($"\"{originalArr[i]}\"");
        if (i < originalArr.Length - 1) // расставляет запятые между всеми элементами кроме крайнего
        {
            Console.Write(", ");
        }
    }

    Console.Write("]");

    Console.Write(" -> ");

    Console.Write("[");

    for (int j = 0; j < editedArr.Length; j++)
    {
        Console.Write($"\"{editedArr[j]}\"");
        if (j < editedArr.Length - 1) // расставляет запятые между всеми элементами кроме крайнего
        {
            Console.Write(", ");
        }
    }

    Console.Write("]");
}

string[] GenArr()
{
    Console.WriteLine("Введите количество элементов массива: ");
    int lenArr = int.Parse(Console.ReadLine()!);
    string[] strArr;
    if (lenArr <= 0)
    {
        Console.WriteLine($"Извините значение не может быть: {lenArr}");
        return strArr = new string[] {};
    }
    else
    {
        strArr = new string[lenArr];

        for (int i = 0; i < strArr.Length; i++)
        {
            Console.Write($"Введите элемент {i + 1} из {lenArr}: ");
            strArr[i] = Console.ReadLine()!;
        }
        
        return strArr;
    }
}







string[] newArr_1 = ThreeAndUnder(arr_1);
PrintTwoArrays(arr_1, newArr_1);

Console.WriteLine("\n");

string[] newArr_2 = ThreeAndUnder(arr_2);
PrintTwoArrays(arr_2, newArr_2);

Console.WriteLine("\n");

string[] newArr_3 = ThreeAndUnder(arr_3);
PrintTwoArrays(arr_3, newArr_3);

Console.WriteLine("\n");

string[] arr_4 = GenArr();
string[] newArr_4 = ThreeAndUnder(arr_4);
PrintTwoArrays(arr_4, newArr_4);


