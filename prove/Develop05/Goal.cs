public class Goal
{
    protected string _name = "";
    protected string _description = "";
    protected int _points = 0;
    protected Boolean _completed = false;

    

    public Goal(string name, string description, int points, Boolean completed)
    {
        _name = name;
        _description = description;
        _points = points;
        _completed = completed;
    }
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _completed = false;
    }
    public Goal(string name, string description)
    {
        _name = name;
        _description = description;
        _points = 25;
        _completed = false;
    }
    public Goal(string name)
    {
        
        _name = name;
        _description = "A task not important enough for a description";
        _points = 25;
        _completed = false;
    }
    public Goal(string name, int points)
    {
        _name = name;
        _description = "A task not important enough for a description";
        _points = points;
        _completed = false;
    }
    public Goal()
    {
        _name = "Goal";
        _description = "A task not importatnt enough for a description";
        _points = 25;
        _completed = false;
    }

    public virtual void Complete()
    {
        _completed = true;
    }
    public virtual void Display()
    {
        if (_completed)
        {Console.WriteLine($"[X] {_name} ({_description})");}
        else {Console.WriteLine($"[ ] {_name} ({_description})");}
    }
    public virtual int PointAward()
    {
        return _points;
    }
    public virtual string GoalString()
    {
        return $"{GetType().Name}||{_name}||{_description}||{_points}||{_completed}";
    }
    public string GetName()
    {
        return _name;
    }
}