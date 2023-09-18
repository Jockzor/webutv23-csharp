using _00_Repetition.Interfaces;
using _00_Repetition.Services;

namespace _00_Repetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMenuService menuService = new MenuService();
            menuService.MainMenu();
        }
    }
}