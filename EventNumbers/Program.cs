// Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел. 
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


int[] createArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 10);
    }
    return array;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

int[] eventArray(int[] array)
{
    int[] eventNumber = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            eventNumber[i] = array[i];
    }
    return eventNumber;
}

int[] zeroOffArray(int[] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != 0)
            array[temp++] = array[i];
    }
    int[] zeNumber = new int[temp];
    Array.Copy(array, 0, zeNumber, 0, temp);
    return zeNumber;
}

Console.Write("Для создания одномерного массива, введите его размер: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] mainArray = createArray(N);
printArray(mainArray);
Console.WriteLine();

Console.WriteLine("Для вывода на экран четных элементов массива, нажмите любую клавишу.");
Console.ReadKey();

int[] eventNumbers = eventArray(mainArray);
//printArray(eventNumbers);
//Console.WriteLine();
int[] zeroOff = zeroOffArray(eventNumbers);
printArray(zeroOff);