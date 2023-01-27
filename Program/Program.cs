string[] arr1 = {"Helloy", "2","world", ":-)"};
string[] arr2 = {"1234", "1567", "-2","computer science"};
string[] arr3 = {"Russia", "Denmark", "Kazan"}; // Заданные массивы.

    string [] ShortsArray (string[] array)// Функция создания нового массива из элементов <=3
    {
        int length = array.Length;
        string [] result = new string[length];
        int count = 0;
        for (int i = 0; i < length; i++)
        {
            if (array[i].Length <=3)
            {
                result[count] = array[i];
                count ++;
            }
            Array.Resize(ref result, count);//Создаем новый массив. В массиве count елементов.
        }
        return result;
    }
    