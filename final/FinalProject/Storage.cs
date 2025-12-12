using System.Runtime.CompilerServices;

public abstract class Storage
{
    private int _maxSlots = 0;

    public Storage(int maxSlots)
    {
        SetMaxSlots(maxSlots);
    }
    public Storage()
    {
       SetMaxSlots(10);
    }

    public abstract void Display();

    public int GetMaxSlots()
    {
        return _maxSlots;
    }
    public void SetMaxSlots(int maxSlots)
    {
        _maxSlots = maxSlots;
    }
    public abstract void Discard(Items item);

}