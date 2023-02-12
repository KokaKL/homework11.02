// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// int InputInt(string message)

double[] array = new double[4];
System.Console.WriteLine($"Введите Коэффициенты b1, k1, b2, k2, соответственно ");
for (int i = 0; i < array.Length; i++)
    {
        string I =  Console.ReadLine();
        array[i] = Convert.ToDouble(I);
    }
double Find_x(double[] arr)
{
    double x = (array[0] - array[2]) / (array[3] - array[1]);
    return x;
}

double Find_y(double[] arr)
{
    double x = Find_x(arr);
    double y = arr[0]*x + arr[1];
    return y;
}
double X = Find_x(array);
double Y = Find_y(array);
System.Console.WriteLine();
System.Console.WriteLine(X);
System.Console.WriteLine(Y);