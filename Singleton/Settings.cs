using System;

namespace DesignPatterns
{
    /// <summary>
    /// Singleton class for managing application settings.
    /// </summary>
    public sealed class Settings
    {
        // Static instance of the class, accessed via GetInstance method.
        private static Settings _instance;

        // Lock object for thread safety, ensuring only one thread can initialize the instance.
        private static readonly object _lock = new object();

        // Private constructor to prevent external instantiation.
        private Settings() { }

        /// <summary>
        /// Gets the single instance of the Settings class, creating it if it doesn't exist.
        /// </summary>
        /// <returns>The single instance of the Settings class.</returns>
        public static Settings GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock) // Ensure thread safety during instance creation.
                {
                    if (_instance == null)
                    {
                        _instance = new Settings();
                    }
                }
            }
            return _instance;
        }

        // Field to store the current graphic quality setting.
        public string QualityOfGraphic { get; private set; } = "Low";

        /// <summary>
        /// Changes the quality of graphics if the provided value is valid.
        /// </summary>
        /// <param name="quality">The desired graphic quality.</param>
        /// <returns>True if the quality was successfully changed; otherwise, false.</returns>
        public bool ChangeQualityOfGraphic(GraphicQuality quality)
        {
            // Validate that the provided value exists in the GraphicQuality enum.
            if (!Enum.IsDefined(typeof(GraphicQuality), quality)) return false;

            QualityOfGraphic = quality.ToString(); // Update the quality setting.
            return true;
        }
    }

    /// <summary>
    /// Enum representing graphic quality levels.
    /// </summary>
    public enum GraphicQuality
    {
        Low,
        Medium,
        High,
    }
}