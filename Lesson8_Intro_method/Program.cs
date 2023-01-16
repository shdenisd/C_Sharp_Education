int a1 = 100;
int b1 = 12;
int c1 = 10;
int a2 = 159;
int b2 = 2;
int c2 = 48;
int a3 = 0;
int b3 = 7;
int c3 = 3;


int MostOfThree (int Number1, int Number2, int Number3)
{
    int max = Number1;
    if (Number2 > max) max = Number2;
    if (Number3 > max) max = Number3; 
    return max;
}


int Max = MostOfThree
(
    MostOfThree(a1, b1, c1), 
    MostOfThree(a2, b2, c2), 
    MostOfThree(a3, b3, c3)
);

Console.WriteLine(Max);