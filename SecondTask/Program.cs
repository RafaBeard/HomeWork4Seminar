Console.Write("Введите число: ");
int num_N = Convert.ToInt32(Console.ReadLine());

int SumNumber(int num_N)
{
    
    int counter = Convert.ToString(num_N).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      advance = num_N - num_N % 10;
      result = result + (num_N - advance);
      num_N = num_N / 10;
    }
   return result;
}

int sumNumber = SumNumber(num_N);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);