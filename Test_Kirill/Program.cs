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
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

string NewString(int N)
{
    var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()[]{}/|?<>";
    int random_length = new Random().Next(1, N);
    var stringChars = new char[random_length];
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


void PrintMatrix(string[] col)
{
    int count = col.Length;
    if (count > 0)
    {
        int position = 0;
        Console.Write("[");
        while (position < count)
        {
            if (position == (count - 1))
            {
                Console.Write($"'{col[position]}'");
                position++;
            }
            else
            {
                Console.Write($"'{col[position]}',");
                position++;
            }
        }
        Console.WriteLine("]");
    }
    else { Console.WriteLine("Массива не существует"); }
}


string[] ChangeArray(string[] array)
{
    string[] matrix = new string[array.Length];
    int num_pos = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i].Length < 4)
        {
            matrix[num_pos] = array[i];
            num_pos++;
        }
    }

    Array.Resize(ref matrix, num_pos);
    return matrix;
}


Console.Clear();
int numberM = Prompt("Введите число элементов исходного массива: ");
string[] matrix = NewArray(numberM, 8);
Console.WriteLine("Исходный массив:");
PrintMatrix(matrix);
string[] array = ChangeArray(matrix);
Console.WriteLine("Сформированный массив:");
PrintMatrix(array);