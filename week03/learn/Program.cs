using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n======================\nDuplicate Counter\n======================");
        DuplicateCounter.Run();

        Console.WriteLine("\n======================\nTranslator\n======================");
        Translator.Run();

        // Write code to find the first time in a string when a letter is duplicated.
        // Answer each of the following:
        //    - What are possible scenarios to consider? (For example, think of a few strings that you would want to try with your solution.)
        //        - "racecar", outputs c
        //        - "and" should return -9999, nan, etc. based on preference or requirements
        //        - "the quick brown fox jumped over the lazy dog" outputs o
        //        - "ten wizards warily watched from whence they were coming" outputs w
        //
        //    - What are some data structures that may be useful? And what would their performance be?
        //        - you could use a hash table or set at O(n) complexity
        //        - you could use an array or list which could be done at O(n^2) complexity
        //        - you could use a pre-populated dictionary<string, bool> populated with keys a-z and all values at false
        //
        //    - What are the boundary conditions that you should consider for this problem?
        //        - strings of differing lengths
        //        - one or both strings being empty
        //        - strings with special characters (many can be stored as text but should they be omitted or do they count)
        //        - handling quotation
        //        - really long strings
        //        - really short strings 
        //        - numbers (they can be stored as text but should they be omitted or do they count)
        //
        //    - Outline a possible solution.
        //        - My recommendation would be to use a list. there is a maximum of 26 possible letters meaning a maximum size of 26.
        //          dictionaries and hash maps are overkill. Don't over engineer. 
    }
}