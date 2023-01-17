int[] array = { 12, 11, 6, 45, 65, 230, 6, 3, 8, 5, 6 };

void find_index(int[] array, int UserNumber)
{
    int counter = 0;
    int length_of_array = array.Length;
    bool flag = false;  // флаг, что бы искать посторяющиеся искомые значения в массиве
    int[] next_find_index = new int[length_of_array]; // новый массив для сбора повторяющихся искомых значений в первом массиве
    int counter2 = 0; // счётчик повторяющихся инедксов 

    while (counter < length_of_array)
    {
        if (flag == true && array[counter] == UserNumber)
        {
            next_find_index[counter2] = counter;
            counter2++;
        }
        if (flag == false && array[counter] == UserNumber)
        {
            Console.WriteLine($"Искомое число {UserNumber}, находится в массиве по индексу {counter}");
            flag = true;
        }
        counter++;
    }
    if (counter2 == 1)  // если нашли одно значение, просто выводим его на экран
    {
        Console.WriteLine($"А также по индексу {next_find_index[0]}");
    }
    if (counter2 > 1) // если нашли больше одного значение, то выводим сначала надпись "А также по индексам" и далеее циклом выводим все эти значения
    {
        counter = 0; // сбрасываем первый счётчик, чтобы пройтись по новому массиву
        Console.Write("А также по индексам: ");
        while (counter < counter2)
        {
            Console.Write($"{next_find_index[counter]} ");
            counter++;
        }
        
    }
    if (flag == false)
    {
        Console.WriteLine("Таких значений не найденно!");
    }
}


Console.Write("Введите число, а я проверю, по какому индексу оно в массиве: ");
find_index(array, int.Parse(Console.ReadLine())); // число для поиска в массиве передаётся сразу в наш метод