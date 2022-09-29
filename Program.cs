// Task 25

double raiseToDegree(int number, int degree)
{
    double result = Math.Pow(number, degree);
    return result;
}
Console.WriteLine("Введите 2 числа: ");
Console.WriteLine(raiseToDegree(Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())));