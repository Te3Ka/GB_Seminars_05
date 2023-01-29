/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Напишите программу по поиску заданного элемента в случайном массиве.
*/

//Метод с указанием автора
void Author()
{
    Console.WriteLine();
    Console.WriteLine("Программа создана Te3Ka_PaynE.");
    Console.WriteLine("E-mail: Mnement4813@yandex.ru");
    Console.WriteLine();
}

int[] GenerateArray(int elements)
{
    int[] newArray = new int[elements];
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write($"Введите {i + 1}-й элемент массива: ");
        int.TryParse(Console.ReadLine(), out newArray[i]);
    }
    return newArray;
}

void PrintArray(int[] printArray)
{
    Console.Write("[");
    for (int i = 0; i < printArray.Length; i++)
    {
        if (i == (printArray.Length - 1))
            Console.WriteLine($"{printArray[i]}]");
        else
            Console.Write($"{printArray[i]}, ");
    }
}

string FindElement(int[] findArray, int findNumber)
{
    for (int i = 0; i < findArray.Length; i++)
    {
        if (findNumber == findArray[i])
            return "присутствует";
    }
    return "отсутствует";
}

Console.WriteLine("Программа запрашивает массив, а затем ищет в нём указанное число.");
Console.Write("Введите количество элементов массива (больше 1): ");
int.TryParse(Console.ReadLine(), out int num);
{
    while (num <= 0)
    {
        Console.Write("Введено неверное число. Введите повторно: ");
        int.TryParse(Console.ReadLine(), out num);
    }
}

int[] array = GenerateArray(num);
PrintArray(array);

Console.Write("Введите число для поиска: ");
int.TryParse(Console.ReadLine(), out int findNum);

Console.WriteLine($"Искомое число {findNum} в массиве {FindElement(array, findNum)}");

Author();