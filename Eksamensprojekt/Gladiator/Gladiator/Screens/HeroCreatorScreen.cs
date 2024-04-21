using Gladiator.Application;
using Gladiator.Application.Characters;
using Gladiator.Interfaces;

namespace Gladiator.Screens
{
    public class HeroCreatorScreen : IScreen
    {
        public static void Render()
        {
            Console.Clear();
            Console.WriteLine("\nSelect a background for your hero:");
            Console.WriteLine("----------------------------------\n");

            List<Background> backgrounds = BackgroundsRepository.Backgrounds;

            for (int i = 0; i < backgrounds.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {backgrounds[i].Name}\t{backgrounds[i].Description}");
                Console.WriteLine($"Bonus:\tAttack: {backgrounds[i].AttackBonus}\tDefense: {backgrounds[i].DefenseBonus}\tLife: {backgrounds[i].LifeBonus}\n");
            }

            Console.Write("Your selection: ");
        }
    }
}
