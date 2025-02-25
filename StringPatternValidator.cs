using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

public class StringPatternValidator
{
    private List<Regex> regexPatterns; // List to store compiled regex patterns

    // Constructor to load patterns from a file
    public StringPatternValidator(string filePath)
    {
        regexPatterns = new List<Regex>();
        LoadPatterns(filePath);
    }

    // Load regex patterns from a text file
    private void LoadPatterns(string filePath)
    {
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    // Ensure line is not null before trimming
                    if (line != null)
                    {
                        line = line.Trim();

                        // Ignore empty lines and comments
                        if (line.Length > 0 && !line.StartsWith("#"))
                        {
                            try
                            {
                                regexPatterns.Add(new Regex(line, RegexOptions.Compiled));
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Invalid regex skipped: {0} ({1})", line, e.Message);
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Loaded {0} patterns.", regexPatterns.Count);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading patterns file: " + ex.Message);
        }
    }

    // Check if the input string matches any pattern
    public bool IsValid(string input)
    {
        foreach (Regex pattern in regexPatterns)
        {
            if (pattern.IsMatch(input))
            {
                return false; // Match found => NOT-VALID
            }
        }
        return true; // No match => VALID
    }
}
