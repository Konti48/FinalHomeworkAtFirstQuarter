/* Написать программу, которая из имеющегося массива строк формирует массив
из строк, длина которых меньше либо равна 3 символа. Первоначальный массив
можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При
решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

["hello", "2", "world", ":-)", "215", "non", "null"] => ["2", ":-", "215", "non"]

*/

string[] array = new string[] { "hello", "2", "world", ":-)", "215", "non", "null" };
int sizeToDisplay = 3;

string[] GetNewArray(string[] array, int sizeToDisplay)
{
    int newSize = 0;
    foreach (string key in array)
    {
        if (key.Length <= sizeToDisplay) newSize++;
    }
    string[] newArray = new string[newSize];
    for (int i = 0, k = 0; i < array.Length; i++)
    {
        if (array[i].Length <= sizeToDisplay)
        {
            newArray[k] = array[i];
            k++;
        }
    }

    return newArray;
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

PrintArray(GetNewArray(array, sizeToDisplay));


