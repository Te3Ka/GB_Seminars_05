/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Задайте массив из 12 элементов, заполненных случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных чисел отдельно друг от друга.

[3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6]
Сумма положительных чисел 29
Сумма отрицательных чисел -20
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
    int[] newArray = new int[12];
    Random rand = new Random();
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rand.Next(-9, 10);
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

int SumPositivesNumbers(int[] positiveArray)
{
    int sumPos = 0;
    for (int i = 0; i < positiveArray.Length; i++)
    {
        if (positiveArray[i] > 0)
        {
            sumPos += positiveArray[i];
        }
    }
    return sumPos;
}

int SumNegativesNumbers(int[] negativeArray)
{
    int sumNeg = 0;
    for (int i = 0; i < negativeArray.Length; i++)
    {
        if (negativeArray[i] < 0)
        {
            sumNeg += negativeArray[i];
        }
    }
    return sumNeg;
}

Console.WriteLine("Программа генерирует массив случайных чисел от -9 до 9, а после считает сумму положительных и отрицательных чисел");
int[] randomeArray = GenerateArray();
PrintArray(randomeArray);
Console.WriteLine($"Сумма положительных чисел = {SumPositivesNumbers(randomeArray)}");
Console.WriteLine($"Сумма отрицательных чисел = {SumNegativesNumbers(randomeArray)}");
Author();