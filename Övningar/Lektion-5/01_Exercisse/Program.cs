using _01_Exercisse.Services;

namespace _01_Exercisse
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var menuService = new MenuService();
            menuService.MainMenu();
        }
    }
}