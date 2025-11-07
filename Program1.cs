using System;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double nalog = 0.13;
            const double nadbavka = 1.20;
            const double super = 300.0;
            const double smena = 8.0;

            Console.WriteLine("введите сумму оклада в руб./час");
            double oklad = double.TryParse(Console.ReadLine());
            Console.WriteLine("введите количество отработанных дней");
            double time = double.TryParse(Console.ReadLine());
            Console.WriteLine("введите количество ночных смен");
            double nighttime = double.TryParse(Console.ReadLine());
            Console.WriteLine("введите количество сверхурочных часов");
            double hours = double.TryParse(Console.ReadLine());

            double oksum = oklad * smena * time;
            double nightsum = nighttime * smena * oklad * nadbavka;
            double supersum = hours * super;


            double allsum = (oksum + nightsum + supersum );
            double result = allsum * (1 - nalog);

            //allsum = ;
            //result = ;
            Console.WriteLine("результат:");
            Console.WriteLine($"сумма выплат за отработанные дни: {Math.Round(oksum, 2)}");
            Console.WriteLine($"сумма выплат за ночные смены: {Math.Round(nightsum, 2)}");
            Console.WriteLine($"сумма выплат за сверхурочные часы: {Math.Round(supersum, 2)}");

            Console.WriteLine($"зарплата до вычета налога: {Math.Round(allsum, 2):F2}");
            Console.WriteLine($"итоговая зарплата: {Math.Round(result, 2)}");
            Console.ReadKey();

        }
    }
}