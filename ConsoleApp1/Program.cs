using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    class Program
    {
        enum Currency {
            Dollar,
            Euro,
            Ruble

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть суму в гривнях:");
            double amount =Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Виберіть валюту для конвертації");
            Console.WriteLine("1.Евро");
            Console.WriteLine("2.Доллар");
            Console.WriteLine("3.Рубли");

            Currency targetCurrency = (Currency)Convert.ToInt32(Console.ReadLine()) - 1;

            double convertedAmount = ConvertCurrency(amount,targetCurrency);
            Console.WriteLine("Конвертована сума:" + convertedAmount);
            Console.ReadLine();
        }
        static double ConvertCurrency(double amount, Currency targetCurrency)
        {
            double conversionRate = GetConversionRate(targetCurrency);
            return amount* conversionRate;

        }
        static double GetConversionRate(Currency targetCurrency)
        {
            switch(targetCurrency)
            {
                case Currency.Euro:
                    return 0.025;
                case Currency.Dollar:
                    return 0.027;
                case Currency.Ruble:
                    return 2.06;
                default:
                    throw new ArgumentException("Непідтримуєма валюта");
            }
        }
    }
}
