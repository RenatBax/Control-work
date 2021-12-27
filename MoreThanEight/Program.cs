// Написать программу, которая из имеющегося массива целых чисел формирует массив из чисел, 
// больших 8. Первоначальный массив можно ввести с клавиатуры, либо сгенерировать 
// случайным образом. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

int[] createArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 21);
    }
    return array;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

int[] moreEightArray(int[] array, int m)
{
    int[] moreEight = new int[array.Length];
    int max = m;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            moreEight[i] = array[i];
    }
    return moreEight;
}

int[] zeroOffArray(int[] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != 0) temp++;
    }
    int[] zeroNumber = new int[temp];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i] != 0)
        {
            zeroNumber[j] = array[i];
            j++;
        }
    }
    return zeroNumber;
}

Console.Write("Для создания одномерного массива, введите его размер: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] mainArray = createArray(N);
printArray(mainArray);
Console.WriteLine();

Console.Write("Введите число от 0 до 10: ");
int target = Convert.ToInt32(Console.ReadLine());

int[] maxNumbers = moreEightArray(mainArray, target);

int[] zeroOff = zeroOffArray(maxNumbers);
printArray(zeroOff);
