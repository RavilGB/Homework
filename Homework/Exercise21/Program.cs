void Zadacha21_1()
{
  Console.WriteLine("Введите A[x]");
int numberAx = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите A[y]");
int numberAy = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите A[z]");
int numberAz = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите B[x]");
int numberBx = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите B[y]");
int numberBy = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите B[z]");
int numberBz = Convert.ToInt16(Console.ReadLine());
double D = Math.Sqrt((Math.Pow(numberAx - numberBx, 2) + Math.Pow(numberAy - numberBy,2)+Math.Pow(numberAz - numberBz,2)));
Console.WriteLine(Math.Truncate(100 * D) / 100);
}
//Zadacha21_1();

int GetNumber(string message)
{
  int result = 0;
  bool isCorrect = false;


    while(!isCorrect)
    {
      Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result != 0)
        {
          isCorrect = true;
        }
        else
        {
          Console.WriteLine("Ввели не число или 0. Введите корректное число");
        }
    }
  
  return result;
}

  int x1 = GetNumber("Введите координату x1" );
  int y1 = GetNumber("Введите координату y1" );
  int z1 = GetNumber("Введите координату z1" );
  int x2 = GetNumber("Введите координату x2" );
  int y2 = GetNumber("Введите координату y2" );
  int z2 = GetNumber("Введите координату z2" );

  double Firstsum = Math.Pow((x2 - x1), 2);
  double Secondsum = Math.Pow((y2 - y1), 2);
  double Thirdsum = Math.Pow((z2 - z1), 2);

  double result = Math.Sqrt(Firstsum + Firstsum + Thirdsum);

  Console.WriteLine(result);
