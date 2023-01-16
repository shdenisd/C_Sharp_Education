int[] array = { 12, 11, 45, 65, 230, 6, 3, 8, 5 };

int MostOfThree(int Number1, int Number2, int Number3)
{
    int max = Number1;
    if (Number2 > max) max = Number2;
    if (Number3 > max) max = Number3;
    return max;
}


int Max = MostOfThree
(
    MostOfThree(array[0], array[1], array[2]),
    MostOfThree(array[3], array[4], array[5]),
    MostOfThree(array[6], array[7], array[8])
);

Console.WriteLine(Max);