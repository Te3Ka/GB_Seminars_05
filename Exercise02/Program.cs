/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Напишите программу для замены элементов массива:
положительные меняются на отрицательные и наоборот.
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
    Random rand = new Random();
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rand.Next(-9, 10);
    }
    return newArray;
}

int[] ChangeElements(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] *= (-1);
    return array;
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

Console.WriteLine("Программа меняет знаки элементов массива на противоположные");
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
Console.WriteLine("Первоначальный массив: ");
PrintArray(array);

Console.WriteLine("Изменённый массив: ");
PrintArray(ChangeElements(array));

Author();