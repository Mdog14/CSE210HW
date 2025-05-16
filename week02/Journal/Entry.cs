using System;
//store entries with prompt, date and responses

public class Entry
{
    public string PromptText { }
    public string Response { }
    public string Date { }


    public void Display()
    {
        Console.WriteLine($"Date:{Date}");
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"Response: {Response}");
    }
}