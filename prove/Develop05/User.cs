public class User
{
    private int _points = 0;
    private int _level = 0;

    public User(int points, int level)
    {
        _points = points;
        _level = level;
    }
    public User(int points)
    {
        _points = points;
        _level = 1;
    }
    public User()
    {
        _points = 0;
        _level = 1;
    }
    public void Display()
    {
        Console.WriteLine($"\nLevel: {_level}, Points: {_points} \n");
    }
    public void LevelUp()
    {
        
        while (_points >= (_level * _level * 100))
        {
            _level += 1;
        }

    }
    public void SetLevel(int level)
    {
        _level = level;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
    public void AddPoints(int points)
    {
        _points += points;
    }
    public string UserString()
    {
        return $"{GetType().Name}||{_points}||{_level}";
    }
}