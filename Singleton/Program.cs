namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // You cannot create an instance of the Settings class directly
            // because its constructor is private.
            // For example, the following line is invalid:
            // Settings x = new Settings();

            // Instead, you must access the instance using the GetInstance() method,
            // which implements the Singleton pattern.
            Console.WriteLine("Current Graphics Quality: " + Settings.GetInstance().QualityOfGraphic);

            // Modify the quality of graphics using the ChangeQualityOfGraphic method.
            // This demonstrates how to work with the Singleton instance.
            Settings.GetInstance().ChangeQualityOfGraphic(GraphicQuality.High);

            // Display the updated quality setting to confirm the change.
            Console.WriteLine("Updated Graphics Quality: " + Settings.GetInstance().QualityOfGraphic);
        }
    }
}
