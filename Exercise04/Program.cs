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

int[] GenerateArray()
{
    int[] newArray = new int[123];
    Random rand = new Random();
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rand.Next(0, 1000);
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

int FindElements(int min, int max, int[] findArray)
{
    int count = 0;
    for (int i = 0; i < findArray.Length; i++)
    {
        if ((min <= findArray[i]) && (findArray[i] <= max))
            count++;
    }
    return count;
}

Console.WriteLine("Программа генерирует массив случайных чисел от 0 до 999 в количестве 123 элемента.");
Console.WriteLine("После производит подсчёт всех чисел в отрезке от 10 до 99");
int[] array = GenerateArray();
PrintArray(array);
Console.WriteLine($"Количество элементов от 10 до 99 = {FindElements(10, 99, array)}");

Author();