// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int Prompt(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

string NewString(int N)
{
    var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    int random_length = new Random().Next(1, N);
    var stringChars= new char[random_length];
    for (int i = 0; i < random_length; i++)
    {
        stringChars[i] = chars[new Random().Next(chars.Length)];
    }
    return new String(stringChars);
}

string[] NewArray(int m, int n)
{
    string[] matrix = new string[m];
    for (int i = 0; i < m; i++)
    {
        matrix[i] = NewString(n);
    }
    return matrix;
}

void PrintMatrix(string[] array)
{
    Console.Write($"['{array[0]}'" + ",");
    for (int i = 1; i < array.GetLength(0)-1; i++)
    {
        Console.Write($"'{array[i]}'" + ",");
    }
    Console.Write($"'{array[array.GetLength(0)-1]}'" + "]");

}

// int [,] ChangeArray(int[,] array) 
// {
//     int[,] matrix = new int[array.GetLength(0), array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {   
//             matrix[i, j]=array[j, i];          
//         }      
//     }  
//     return matrix; 
// }


Console.Clear();

int numberM = Prompt("Введите число элементов матрицы: ");
string[] matrix = NewArray(numberM, 8);
Console.WriteLine("Исходный массив:");
PrintMatrix(matrix);

//  
// int[,] array  = ChangeArray(matrix);
// PrintMatrix(array);