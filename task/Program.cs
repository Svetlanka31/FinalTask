// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам.
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[]FirstArray = new string[size];
string[]SecondArray = new string[FirstArray.Length];
void FillArray(string[] array, int size)
{
    for (int i = 0; i < size; i++)
    {
       Console.WriteLine($"Введите {i+1} элемент массива: ");
    array[i] = Convert.ToString(Console.ReadLine());
     
}
Console.WriteLine('[' + string.Join(", ",array) +']');
Console.WriteLine();
    }
    FillArray(FirstArray, size);
void GetSecondArray(string[] FirstArr, string[] SecondArr)
{
    int count = 0;

    for (int i = 0; i < FirstArr.Length; i++)
    {
    if(FirstArr[i].Length <= 3)
        {
        SecondArr[count] = FirstArr[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
   
}
}
GetSecondArray(FirstArray, SecondArray);
PrintArray(SecondArray);