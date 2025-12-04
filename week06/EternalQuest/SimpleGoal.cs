public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, int points,  bool isComplete = false) : base (name, description, points)
    {
         _isComplete = isComplete;
    }
    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");      
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetName()},{GetDescription()},{GetPoints()},{_isComplete}";
    }

    public override string GetDetailsString()
    {
        string check = string.Empty;
        if (IsComplete())
        {
            check = "[X]";
        }
        else
        {
            check = "[ ]";
        }
        
        return $"{check} {base.GetDetailsString()}";
    }
}