using Gladiator.Interfaces;

namespace Gladiator.Screens
{
    public class FirstRoundScreen : IScreen
    {
        public static void Render()
        {
            Console.WriteLine("\nWho knows what your crime was? It doesn't matter anyways.");
            Console.WriteLine("As you are dragged through the cold tunnels beneath the arena,");
            Console.WriteLine("someone thrusts an old dagger into your hands and points to an open gate.");
            Console.WriteLine("\"The crowd yearns for fresh blood. Go die!\", someone whispers.");
            Console.WriteLine("You feel a big push and stumble into the hot sands of the arena.");
            Console.WriteLine("\nPress Enter to commence battle!");
        }
    }
}