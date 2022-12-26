/* Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*/


string[] array1 = {"Hello", "2", "world", ":-)"};
string[] array2 = {"1234", "1567", "-2", "computer science"};
string[] array3 = {"Russia", "Denmark", "Kazan"};
string[] array4 = {"num", "HELLO", "7896", "sum", "Russia", ":-)"};

int max_word_lenght = 3;

string[] ArrayGetShortWords(string[] array)
{
    int length = array.Length;
    string[] result = new string[length];
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= max_word_lenght)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);
    return result;
}

PrintRes(array1);
PrintRes(array2);
PrintRes(array3);
PrintRes(array4);

void WriteArray(string[] array)
{
    if(array.Length == 0)
    {
        Console.WriteLine("Массив пуст");
    }
    else
        {
            Array.ForEach(array, (str) => Console.Write($"{str} "));
            Console.WriteLine();
        }
}

void PrintRes(string[] array)
{
    Console.WriteLine("Исходный массив:");
    WriteArray(array);
    string[] shortArray = ArrayGetShortWords(array);
    Console.WriteLine("Итоговый массив со словами не более трех символов: ");
    WriteArray(shortArray);
    Console.WriteLine();
}