using System;

namespace hello__user
{
    class Program
    {
        static bool CheckData(int day, int month, int year)
        {
            bool FebCheck = true;
            if (month == 2)
            {
                if (day > 28)
                {
                    if (day == 29 && year % 4 == 0)
                    {
                        FebCheck = true;
                    }
                    else
                    {
                        FebCheck = false;
                    }
                }
            }
            if (day > 0 && day <= 31 && month > 0 && month <= 12 && FebCheck == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, как тебя зовут?");
            var name = Console.ReadLine();
            int year;
            bool dataValid;
            int cycleCount = 0;
            do
            {
                if (cycleCount > 0)
                {
                    Console.Clear();
                    Console.WriteLine("Некорректная дата. Попробуйте еще раз.");
                }
                Console.WriteLine("В какой день ты родился?");
                var day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("В каком месяце ты родился?");
                var month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("В каком году ты родился?");
                year = Convert.ToInt32(Console.ReadLine());
                dataValid = CheckData(day, month, year);
                ++cycleCount;
            }
            while (!dataValid);
            Console.WriteLine("Привет, " + name + ". Ваш возраст равен " + (2020 - year) + " лет. Приятно позакомиться.");
        }
    }
}