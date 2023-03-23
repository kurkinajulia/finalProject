//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int GetDataFromUser(string text)// Введение пользователем размера массива.
{
    int value = 0;
    bool flag = false;
    while (!flag)
    {
        Console.Write(text);
        flag = int.TryParse(Console.ReadLine(), out value);
        if (value <= 0)
        {
            Console.WriteLine("Введите целое число больше 0.");
            flag = false;
        }
    }
    return value;
}
void FillArray(string[] array)//Заполнение массива.
{
    int elementsNumber = 1;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {elementsNumber} элемент массива: ");//Введение пользователем n-ого элемента массива.
        array[i] = Console.ReadLine();
        elementsNumber++;
    }
}
void ShowArray(string[] array)//Показ полученного массива.
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
string[] GetResultArray(string[] array)//Создание нового массива с элементами, длина которых меньше или равна 3.
{
    int resultArraySize = 0;
    int indexForArrayResult = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArraySize++;
        }
    }
    string[] arrayResult = new string[resultArraySize];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayResult[indexForArrayResult] = array[i];
            indexForArrayResult++;
        }
    }
    return arrayResult;
}

int arraySize = GetDataFromUser("Введите количество элементов массива: ");
string[] array = new string[arraySize];

FillArray(array);
Console.Write("Элементы, длина которых меньше либо равна 3 символа: ");
ShowArray(GetResultArray(array));