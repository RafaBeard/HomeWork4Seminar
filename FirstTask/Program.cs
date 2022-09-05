Console.Write("Введите первое число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());
int Exponentiation(int num_1, int num_2)
{
  int result = 1;
  for(int i=1; i <= num_2; i++)
  {
    result = result * num_1;
  }
    // int result = Math.Pow(num_1, num_2);
    return result;
}
  int exponentiation = Exponentiation(num_1, num_2);
  Console.WriteLine("Ответ: " + exponentiation);