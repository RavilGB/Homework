//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели,
 //и проверяет, является ли этот день выходным.

 Console.WriteLine("Введите любое число от 0 до 10");
 int day = Convert.ToInt32(Console.ReadLine());


 if(day == 6 || day == 7)
 {
    Console.WriteLine("Ура выходной");
 }

    else if (day == 5)
    {
        Console.WriteLine("Наконец-то Пятница!!!");
    }
        else if(day >= 1 && day <= 4)
        {
            Console.WriteLine("Иди работать");
        }
            else
            {
                Console.WriteLine("Неверный ввод числа");
            }

