//13. Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//что третьей цифры нет.

//Random random = new Random();
//int number = random.Next(-1000, 1000);
Console.WriteLine("Введите число от 100 и больше");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
    if (number < 100)
    {
        Console.WriteLine("Число не трехзначное.");
    }
        else
        {
            while(number > 999)
            {
                number = number /=10;
            }
            Console.WriteLine(number % 10);

        }