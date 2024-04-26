using Gladiator.Interfaces;

namespace Gladiator.Screens
{
    public class GameOverScreen : IScreen 
    {
        public static void Render()
        {
            Console.WriteLine("You died!");
            Console.WriteLine("Press Enter to try again!");
        } 
    }
}
