public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps): base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 0.05;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (GetMinutes()/60);
    }

    public override double GetPace()
    {
        return GetMinutes()/GetDistance();
    }
}