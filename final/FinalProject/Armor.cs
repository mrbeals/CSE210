using System.Runtime.CompilerServices;

public class Armor : Items
{
    private string _amrorType = "";
    private int _defense = 0;

    public Armor(string name, string description, int weight, Boolean stackable, string armorType, int defense) : base(name, description, weight, stackable)
    {
        _amrorType = armorType;
        _defense = defense;
    }
    public Armor(string name, string description, int weight, Boolean stackable, int defense) : base(name, description, weight, stackable)
    {
        _amrorType = "helmet";
        _defense = defense;
    }
    public Armor(string name, string description, int weight, Boolean stackable, string armorType) : base(name, description, weight, stackable)
    {
        _amrorType = armorType;
        _defense = 0;
    }
    public Armor(string name, string description, int weight, int defense) : base(name, description, weight)
    {
        _amrorType = "helmet";
        _defense = defense;
    }
    public Armor(string name, string description, string armorType, int defense) : base(name, description)
    {
        _amrorType = armorType;
        _defense = defense;
    }
    public Armor(string name, string description, int weight, string armorType) : base(name, description, weight)
    {
        _amrorType = armorType;
        _defense = 0;
    }
    public Armor(string name, string description, int weight, Boolean stackable) : base(name, description, weight, stackable)
    {
        _amrorType = "helmet";
        _defense = 0;
    }
    public Armor(string name, string description, int weight) : base(name, description, weight)
    {
        _amrorType = "helmet";
        _defense = 0;
    }
    public Armor(string name, string description) : base(name, description)
    {
        _amrorType = "helmet";
        _defense = 0;
    }
    public Armor(string name, int weight) : base(name, weight)
    {
        _amrorType = "helmet";
        _defense = 0;
    }
    public Armor(string name, Boolean stackable) : base(name, stackable)
    {
        _amrorType = "helmet";
        _defense = 0;
    }
    public Armor(string name) : base(name)
    {
        _amrorType = "helmet";
        _defense = 0;
    }
    public Armor() 
    {
        _amrorType = "helmet";
        _defense = 0;
    }
    public string GetArmorType()
    {
        return _amrorType;
    }
    public void SetArmorType(string armorType)
    {
        _amrorType = armorType;
    }
    public int GetDefense()
    {
        return _defense;
    }
    public void SetDefense(int defense)
    {
        _defense = defense;
    }
    public override void Display()
    {
        
    }
}