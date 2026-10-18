public class PromptGenerator
{
  public List<string> _prompts = new List<string>
  {
    "If I had one thing I could do over today, what would it be?",
    "What was the best part of my day?",
    "Who was the most interesting person I interacted with today?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "What did I learn today that changed how I think?",
    "When did I feel closest to God today?",
    "What did I do today that my future self will thank me for?",
    "Who needed my kindness today, and how did I respond?",
    "What challenged my patience today, and what did it teach me?",
    "What am I grateful for that I usually take for granted?",
    "Did the way I spent my time today reflect what matters most to me?",
    "What mistake did I make today, and what can I learn from it?",
    "What small moment today do I want to remember?",
    "What did I avoid today, and what was holding me back?",
    "How did I show love to my family today?",
    "What question about my faith or life am I thinking about?",
    "When did I feel most like myself today?",
    "What did someone else's perspective help me understand today?",
    "What is one thing I need to let go of tonight?",
    "Where did I notice progress in something I have been working on?",
    "What did I do today because it was right, even though it was difficult?",
    "What would I tell a friend who was facing the same struggles I am?",
    "What could I do tomorrow to make someone's day better?",
    "What kind of person am I becoming through my daily choices?"
  };

  public Random _random = new Random();
  public string GetRandomPrompt()
  {
    int index = _random.Next(_prompts.Count);
    return _prompts[index];
  }
}