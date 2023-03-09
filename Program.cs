/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

string[] GetString()
{
    string[] words = new string[6];
    for (int i = 0; i < words.Length; i++)
    {
        Console.WriteLine("Введите слово");
        words[i] = Console.ReadLine();
    }
return words;
}

void PrintArray(string[] words)
{
    for (int i = 0; i < words.Length; i++)
    {
        if(words[i].Length < 4)
        {
            Console.Write($"{words[i]} ");
        }
        else continue;
    }
}

string[] text = GetString();
PrintArray(text);