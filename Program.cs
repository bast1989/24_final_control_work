string[] arr_1 = {"Hello", "2", "world", ":-)"};
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
        return myArr = new string[] {" "}; 
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
                i++;
            }            
        }
        return myArr;
    }
}

ThreeAndUnder(arr_1);
Console.WriteLine();
ThreeAndUnder(arr_2);
Console.WriteLine();
ThreeAndUnder(arr_3);
