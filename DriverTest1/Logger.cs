using System;
using System.IO;

public class Logger
{
    public static void LogMessage(string filePath, string message, string logLevel, string timestampFormat = "[yyyy-MM-dd HH:mm:ss]")
    {
        try
        {
            // Check if the log level is valid
            if (!(logLevel == "INFO" || logLevel == "WARNING" || logLevel == "ERROR"))
            {
                Console.WriteLine("Invalid log level: " + logLevel);
                return;
            }

            // Check if the message is empty
            if (string.IsNullOrWhiteSpace(message))
            {
                Console.WriteLine("Message cannot be empty");
                return;
            }

            // Generate the timestamp
            string timestamp = DateTime.Now.ToString(timestampFormat);

            // Create the log entry
            string logEntry = $"[{timestamp}] [{logLevel}] {message}";

            // Write the log entry to the file
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(logEntry);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
