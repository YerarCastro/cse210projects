public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity()
        : base("Reflection Activity", "This activity helps you reflect on times you showed strength.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "How did you feel when it was complete?",
            "What did you learn from this experience?"
        };
    }

    public void RunActivity()
    {
        DisplayStartingMessage();
        Random random = new Random();

        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);

        for (int i = 0; i < GetDuration(); i += 10)
        {
            Console.WriteLine(_questions[random.Next(_questions.Count)]);
            Countdown(5);
        }

        DisplayEndingMessage();
    }

    private void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
