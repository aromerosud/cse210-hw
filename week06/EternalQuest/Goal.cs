public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int point)
    {
        _points = point;
    }

    /*
    This method should perform the necessary actions for each specific type of goal, such as marking a simple goal as completed or increasing the completion count
    for a checklist goal. It should return the number of points associated with recording the event (keep in mind that in some cases it may include a bonus,
    for example, if a checklist goal has just been fully completed).
    */
    public abstract void RecordEvent();
    
    
    // This method should return true if the goal is complete. The way to determine
    // whether it is complete varies for each type of goal.
    public abstract bool IsComplete(); 


    // This method should return the details of a goal that can be displayed in a list.
    // It must include the checkbox, the short name, and the description. In the case of
    // the ChecklistGoal class, it should be overridden to also show how many times the
    // goal has been completed so far.
    public virtual string GetDetailsString()
    {
        return $"{_shortName} ({_description})";
    }

    // This method should provide all the details of a goal in a way that is easy to save
    // to a file and load again later.
    public abstract string GetStringRepresentation();

}