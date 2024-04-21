using Gladiator.Application.Characters;
using Newtonsoft.Json;

namespace Gladiator.Application
{
    public static class BackgroundsRepository
    {
        public static List<Background> Backgrounds { get; private set; }

        // Load backgrounds from JSON file and initialize the list
        public static void Initialize(string relativeConfigFilePath)
        {
            // Get the directory of the executable
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Navigate up two levels to reach the solution's root directory
            string solutionDirectory = Path.GetFullPath(Path.Combine(exeDirectory, @"..\..\.."));

            // Combine the solution directory with the relative path to the JSON file
            string jsonFilePath = Path.Combine(solutionDirectory, "Application", "Data", relativeConfigFilePath);

            // Read JSON from file
            string json = File.ReadAllText(jsonFilePath);

            // Deserialize JSON to list of Background objects
            Backgrounds = JsonConvert.DeserializeObject<List<Background>>(json);
        }
    }
}

