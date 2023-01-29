/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат записать в новом массиве.
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
        newArray[i] = rand.Next(1, 10);
    }
    return newArray;
}

int[] PowArray(int[] oldArray)
{
    int newLength = 0;
    if (oldArray.Length % 2 == 1)
    {
        newLength = oldArray.Length / 2 + 1;
    }
    else
    {
        newLength = oldArray.Length / 2 ;
    }

    int[] newArray = new int[newLength];
    for (int i = 0, j = oldArray.Length - 1; i <= j; i++, j--)
    {
        if (i == j)
            newArray[i] = oldArray[i];
        else
            newArray[i] = oldArray[i] * oldArray[j];
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

Console.WriteLine("Программа генерирует массив случайных чисел от 1 до 9, после считает произведение двух элементов попарно.");
Console.WriteLine("При этом, парой считается первый и последний, второй и предпоследний и т.д. элементы массива");
Console.WriteLine("После выводит значения в виде нового массива.");
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
int[] powArray = PowArray(array);
PrintArray(powArray);

Author();