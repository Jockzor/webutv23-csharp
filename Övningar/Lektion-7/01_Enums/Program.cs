using _01_Enums.Enums;
using _01_Enums.Services;

namespace _01_Enums
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            WeekdayService weekdayService = new WeekdayService();
            var urlCheckerService = new UrlCheckerService();
            await urlCheckerService.Run("https://google.com");
            //weekdayService.Run();
           // WeekdayService.Run(); // Om Run metoden är static

        }
    }
}