// Напишите программу,
   //  которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("И третье число");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
         if (b > max)
             {
                max = b;
             }
        if  (c > max)
             {
                  max=c;
             }
Console.Write("Максимальное число = "+max);
