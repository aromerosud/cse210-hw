public class ChecklistGoal: Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted = 0) : base (name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
        // Luego, debe establecer la cantidad completada para que comience en 0.
    }
    public override void RecordEvent()
    {
        _amountCompleted += 1;
        if (IsComplete())
        {
            SetPoints(GetPoints() + _bonus);
        }   
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");    
    }

    public override bool IsComplete()
    {
        bool result = false;
        if (_amountCompleted == _target)
        {
            result = true;
        }
        return result;        
    }

    public override string GetStringRepresentation()
    {
        return $"CheckListGoal:{GetName()},{GetDescription()},{GetPoints()},{_bonus}, {_target}, {_amountCompleted}";
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
        
        return $"{check} {base.GetDetailsString()} -- Currently completed: {_amountCompleted}/{_target}";
    }
}