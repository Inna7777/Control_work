string[] arr1 = {"Helloy", "2","world", ":-)"};
string[] arr2 = {"1234", "1567", "-2","computer science"};
string[] arr3 = {"Russia", "Denmark", "Kazan"}; // Заданные массивы.

    string [] ShortsArray (string[] array)  // Функция создания нового массива из элементов <=3
    {
        int length = array.Length;
        string [] result = new string[length];
        int count = 0;
        for (int i = 0; i < length; i++)
        {
            if (array[i].Length <= 3)
            {
                result[count] = array[i];
                count ++;
            }
            Array.Resize(ref result, count);//Создаем новый массив. В массиве count елементов.
        }
        return result;
    }
    void PrintNewArray(string[] newArray) //Функция вывода полученного нового массива
    {
        if ( newArray.Length == 0)
        {
            Console.WriteLine("Нет нужного елемента массива");
        }
        else
        {
            Array.ForEach(newArray, (str) => Console.Write($"{str}"));// Отображение элементов с помощью ForEach. 
            Console.WriteLine();
        }
    }
void PrintArr(string[] array)
{
    Console.WriteLine($"Заданный массив:");
    PrintNewArray(array);//Выводим на экран заданный массив
    Console.WriteLine($"Результат:");
    string[] newArray = ShortsArray(array);
    PrintNewArray(newArray);//Выводим на экран новый массив и елемтов удовлетворяющим условию
    Console.WriteLine();
}

PrintArr (arr1);
PrintArr (arr2);
PrintArr (arr3);

