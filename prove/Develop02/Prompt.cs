class Prompt
{
    // attributes
    public string promptContainer;
    public List<string> _prompts = new List<string>
    {
        "What was the hardest part of my day?",
        "Did the lord talk to me today?",
        "What made me smile today?",
        "Any new smells I smelt today?",
        "What new thing did I learn today?"
    };
    public string getPrompt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Count);
        promptContainer = _prompts[index];
        return promptContainer;
    }
}