int[] array = { 12, 11, 6, 45, 65, 230, 6, 3, 8, 5, };

int MostOfThree(int Number1, int Number2, int Number3)
{
    int max = Number1;
    if (Number2 > max) max = Number2;
    if (Number3 > max) max = Number3;
    return max;
}


void find_index(int[] array, int UserNumber)
{
    int counter = 0;
    int length_of_array = array.Length;
    while (counter < length_of_array)
    {
        if (array[counter] == UserNumber)
        {
            Console.WriteLine($"Искомое число {UserNumber}, находится в массиве по индексу {counter}");
        }
        counter++;
    }

}



Console.Write("Введите число, а я проверю, по какому индексу оно в массиве: ");
find_index(array, int.Parse(Console.ReadLine())); // число для поиска в массиве передаётся сразу в наш метод



