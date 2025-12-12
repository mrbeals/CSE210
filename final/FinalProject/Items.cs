using System.ComponentModel.DataAnnotations;
using System.Reflection;

public abstract class Items
{
    private string _name = "";
    private string _description = "";
    private int _weight = 0;
    private Boolean _stackable = false;

    public Items(string name, string description, int weight, Boolean stackable) 
    {
        SetName(name);
        SetDescription(description);
        SetWeight(weight);
        SetStackable(stackable);
    }
    public Items(string name, string description, int weight) 
    {
        SetName(name);
        SetDescription(description);
        SetWeight(weight);
        SetStackable(false);
    }
    public Items(string name, string description) 
    {
        SetName(name);
        SetDescription(description);
        SetWeight(1);
        SetStackable(false);
    }
    public Items(string name, int weight) 
    {
        SetName(name);
        SetDescription("Not Important enough for a description.");
        SetWeight(weight);
        SetStackable(false);
    }
    public Items(string name, Boolean stackable) 
    {
        SetName(name);
        SetDescription("Not important enought for a description.");
        SetWeight(1);
        SetStackable(stackable);
    }
    public Items(string name) 
    {
        SetName(name);
        SetDescription("Not importatnt enough for a description.");
        SetWeight(1);
        SetStackable(false);
    }
    public Items() 
    {
        SetName("Blank");
        SetDescription("Not importatnt enough for a description.");
        SetWeight(1);
        SetStackable(false);
    }

    public void SetWeight(int weight)
    {
        _weight = weight;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public void SetStackable(Boolean stackable)
    {
        _stackable = stackable;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }
    public Boolean GetStackable()
    {
        return _stackable;
    }

    public int GetWeight()
    {
        return _weight;
    }
    public abstract void Display();

}