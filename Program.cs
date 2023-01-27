// Задача 27: Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


int InputNumber(string str)
{
    int number;
    string? text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }

        System.Console.WriteLine("введено некорректное число");
    }
    return number;

}

int NumSum(int num)
{
    int result = 0;
    int[] digits = Array.ConvertAll(num.ToString("0").ToCharArray(), ch => ch - '0');
    for (int i = 0; i < digits.Length; i++)
        result = result + digits[i];
    return result;
}

int N = InputNumber("введитее число: ");

Console.WriteLine(NumSum(N));

