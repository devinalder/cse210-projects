using System;
using System.Collections.Generic;

class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What was the most unusual part of my day?",
        "What were the highs and lows of my day?",
        "What's one thing I learned today?",
        "What would I do differently if I started this day over?",
        "What would I rate this day on a scale of 1-10 and why?",
        "What's something I should be grateful for from today?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}