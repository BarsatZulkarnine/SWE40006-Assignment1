using System;

namespace GreetingDependency
{
    public class GreetingHelper
    {
        public string GetWelcomeMessage()
        {
            return "App powered by MyApp.Utilities.dll!";
        }

        public string GetTimestamp()
        {
            return $"Loaded on: {DateTime.Now:yyyy-MM-dd HH:mm:ss}";
        }
    }
}