using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            // Ensure the patterns file exists
            string patternFilePath = "sample_inputs.txt";
            if (!File.Exists(patternFilePath))
            {
                Console.WriteLine("Error: Pattern file '{0}' not found.", patternFilePath);
                return;
            }

            // Create an instance of the validator
            StringPatternValidator validator = new StringPatternValidator(patternFilePath);

            // Read input from file
            string inputFilePath = "sample_inputs.txt";
            if (!File.Exists(inputFilePath))
            {
                Console.WriteLine("Error: Input file '{0}' not found.", inputFilePath);
                return;
            }

            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                while (!reader.EndOfStream)
                {
                    string input = reader.ReadLine();
                    
                    // Ensure input is not null
                    if (input != null)
                    {
                        bool isValid = validator.IsValid(input);
                        Console.WriteLine(isValid ? "VALID" : "INVALID");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: {0}", ex.Message);
        }
    }
}
