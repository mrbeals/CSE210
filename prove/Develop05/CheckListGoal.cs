public class CheckListGoal : Goal
{
    private int _completionTimes = 0;
    private int _completionCounter = 0;
    private int _bonusPoints = 0;

    public CheckListGoal(string name, string description, int points, Boolean completed, int completionTimes, int completionCounter, int bonusPoints) : base(name, description, points, completed)
    {
        _completionTimes = completionTimes;
        _completionCounter = completionCounter;
        _bonusPoints = bonusPoints;
    }
    public CheckListGoal(string name, string description, int points, int completionTimes, int completionCounter, int bonusPoints) : base(name, description, points)
    {
        _completionTimes = completionTimes;
        _completionCounter = completionCounter;
        _bonusPoints = bonusPoints;
    }
    public CheckListGoal(string name, string description, int points, int completionTimes) : base(name, description, points)
    {
        _completionTimes = completionTimes;
        _completionCounter = 0;
        _bonusPoints = 30;
    }
    public CheckListGoal(string name, string description, int points, int completionTimes, int bonusPoints) : base(name, description, points)
    {
        _completionTimes = completionTimes;
        _completionCounter = 0;
        _bonusPoints = bonusPoints;
    }
    public CheckListGoal(string name, string description, int points) : base(name, description, points)
    {
        _completionTimes = 10;
        _completionCounter = 0;
        _bonusPoints = 30;
    }
    
    public CheckListGoal(string name, string description) : base(name, description)
    {
        _completionTimes = 10;
        _completionCounter = 0;
        _bonusPoints = 30;
    }
    public CheckListGoal(string name, int completionTimes) : base(name)
    {
        _completionTimes = completionTimes;
        _completionCounter = 0;
        _bonusPoints = 30;
    }
    public CheckListGoal(string name) : base(name)
    {
        _completionTimes = 10;
        _completionCounter = 0;
        _bonusPoints = 30;
    }
    public CheckListGoal(string name, int points, int completionTimes) : base(name, points)
    {
        _completionTimes = completionTimes;
        _completionCounter = 0;
        _bonusPoints = 30;
    }
    public CheckListGoal()
    {
        _completionTimes = 10;
        _completionCounter = 0;
        _bonusPoints = 30;
    }

    public override void Complete()
    {   
        _completionCounter += 1;
        if (_completionCounter == _completionTimes)
        {
            _completed = true;
        }
    }
    public override int PointAward()
    {
        if (_completed)
        {
            return _points + _bonusPoints;
        }
        else
        {
            return _points;
        }
    }
    public override string GoalString()
    {
        return $"{GetType().Name}||{_name}||{_description}||{_points}||{_completed}||{_completionTimes}||{_completionCounter}||{_bonusPoints}";
    }
    public override void Display()
    {
        if (_completed)
        {Console.WriteLine($"[X] {_name} ({_description}) -- Currently completed: {_completionCounter}/{_completionTimes}");}
        else {Console.WriteLine($"[ ] {_name} ({_description}) -- Currently completed: {_completionCounter}/{_completionTimes}");}
}
}