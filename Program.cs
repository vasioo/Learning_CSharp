using System;
namespace FunctionalProgramming
{
    class Program
    {
        static int PromotionsCountToday = 0;
        static void Main(string[] args)
        {
            Console.WriteLine(GetPromotion(100));
        }
        public static decimal GetPromotion(decimal price)
        {
            if (PromotionsCountToday<3)
            {
                if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
                {
                    PromotionsCountToday++;
                    return price - price * 0.2m;
                }
                if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
                {
                    PromotionsCountToday++;
                    return price - price * 0.2m;
                }
            }
            
            return price;
        }
    }
}
