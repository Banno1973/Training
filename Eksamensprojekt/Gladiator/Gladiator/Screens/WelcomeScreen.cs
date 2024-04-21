using Gladiator.Interfaces;

namespace Gladiator.Screens
{
    public class WelcomeScreen : IScreen
    {
        public static void Render()
        {
            Console.WriteLine("\nWelcome to Gladiator!");
            Console.WriteLine("---------------------");
            Console.WriteLine("\nWill you survive long enough to face Brutalis, Champion of the Arena?");
            Console.WriteLine("\"We who are about die salute you!\"");
            Console.WriteLine("\nTo start, please enter your name: ");
        }
    }
}