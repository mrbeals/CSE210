public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points, Boolean completed) : base(name, description, points, completed)
    {

    }
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }
    public EternalGoal(string name, string description) : base(name, description)
    {

    }
    public EternalGoal(string name) : base(name)
    {
        

    }
    public EternalGoal(string name, int points) : base(name, points)
    {

    }
    public EternalGoal() : base()
    {

    }
    public override void Complete()
    {
        PointAward();
    }
}