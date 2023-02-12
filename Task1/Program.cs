// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
int InputInt(string message)
{
    System.Console.WriteLine(message + ">");
    string inputedValie = Console.ReadLine();
    int result = Convert.ToInt32(inputedValie);
    return result;
}
int n = InputInt("Введите количество чисел: ");

int[] array = new int[n];
PrintArray(array);

for (int i = 0; i < n; i++)
    {
        System.Console.WriteLine($"Введите число: ");
        string I =  Console.ReadLine();
        array[i] = Convert.ToInt32(I);
    }

PrintArray(array);

