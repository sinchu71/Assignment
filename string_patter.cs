using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class StringPatternValidator
{
    private List<string> patterns;

    // Constructor initializes predefined patterns
    public StringPatternValidator()
    {
        patterns = new List<string>
        {
            @"\d{3}-\d{2}-\d{4}",   // Example: Social Security Number format (XXX-XX-XXXX)
            @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}", // Email pattern
            @"https?:\/\/(www\.)?\w+\.\w+", // URL pattern
            @"^\d{10}$"  // Phone number (10 digits)
        };
    }

    // Method to validate a string
    public bool IsValid(string input)
    {
        foreach (var pattern in patterns)
        {
            if (Regex.IsMatch(input, pattern))
            {
                return false; // Match found, return NOT-VALID
            }
        }
        return true; // No match, return VALID
    }
}

class Program
{
    static void Main()
    {
        StringPatternValidator validator = new StringPatternValidator();

        Console.WriteLine("Enter a string to validate:");
        string input = Console.ReadLine();

        bool isValid = validator.IsValid(input);
        if (isValid)
        {
            Console.WriteLine("VALID");
        }
        else
        {
            Console.WriteLine("NOT-VALID");
        }
    }
}
