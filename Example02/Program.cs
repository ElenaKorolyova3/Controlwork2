// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше,
 //либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
 //При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Write("Введите размерность массива: ");
int m = Convert.ToInt32(Console.ReadLine());
string [] strArray = new string [m];

void FirstArray(string [] strArray)
{
  for (int i = 0; i < strArray.Length; i++)
  {
     Console.WriteLine($"Введите {i+1} элемент массива");
     strArray[i] = Console.ReadLine();
  }
}

void PrintFirstArray(string [] strArray)
{
    Console.Write("[");
        {
        for (int i = 0; i < strArray.Length; i++)
            {
            Console.Write($"{strArray[i]}, ");
            }
        }
    Console.Write("]");
}

string [] NewArray(string [] strArray)
    {
        int n = 0;
        for (int i = 0; i < strArray.Length; i++)
        {
            if (strArray[i].Length <= 3)
                n++;
        }
string [] result = new string [n];
        int j = 0;
        for (int i = 0; i < strArray.Length; i++)
        {
            if (strArray[i].Length <= 3)
            {
                result[j] = strArray[i];
                j++;
            }
        }
        return result;
    }

FirstArray(strArray);
Console.WriteLine("Исходный массив: ");
PrintFirstArray(strArray);
Console.WriteLine();
Console.WriteLine("Новый массив: ");
PrintFirstArray(NewArray(strArray));
