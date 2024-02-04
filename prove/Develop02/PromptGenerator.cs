using System;

public class PrommptGenerator
{

    public string[]_prompts = new string[]
{
    
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    "What made me smile today?",
    "What challenged me today and how did I overcome it?",
    "Describe a moment of gratitude from today.",
    "What did I learn about myself today?",
    "What goals or intentions do I have for tomorrow?"
};

    public string GetRandomPrompt()

    {
        Random random= new Random();
        int index = random.Next(_prompts.Length);
        return _prompts[index];
    }
}