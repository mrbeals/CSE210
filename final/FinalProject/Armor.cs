using System.Runtime.CompilerServices;

public class Armor : Items
{
    private string _armorType = "";
    private int _defense = 0;

    public Armor(string name, string description, int weight, Boolean stackable, string armorType, int defense) : base(name, description, weight, stackable)
    {
        _armorType = armorType;
        _defense = defense;
    }
    public Armor(string name, string description, int weight, Boolean stackable, int defense) : base(name, description, weight, stackable)
    {
        _armorType = "helmet";
        _defense = defense;
    }
    public Armor(string name, string description, int weight, Boolean stackable, string armorType) : base(name, description, weight, stackable)
    {
        _armorType = armorType;
        _defense = 0;
    }
    public Armor(string name, string description, int weight, int defense) : base(name, description, weight)
    {
        _armorType = "helmet";
        _defense = defense;
    }
    public Armor(string name, string description, string armorType, int defense) : base(name, description)
    {
        _armorType = armorType;
        _defense = defense;
    }
    public Armor(string name, string description, int weight, string armorType) : base(name, description, weight)
    {
        _armorType = armorType;
        _defense = 0;
    }
    public Armor(string name, string description, int weight, Boolean stackable) : base(name, description, weight, stackable)
    {
        _armorType = "helmet";
        _defense = 0;
    }
    public Armor(string name, string description, int weight) : base(name, description, weight)
    {
        _armorType = "helmet";
        _defense = 0;
    }
    public Armor(string name, string description) : base(name, description)
    {
        _armorType = "helmet";
        _defense = 0;
    }
    public Armor(string name, int weight) : base(name, weight)
    {
        _armorType = "helmet";
        _defense = 0;
    }
    public Armor(string name, Boolean stackable) : base(name, stackable)
    {
        _armorType = "helmet";
        _defense = 0;
    }
    public Armor(string name) : base(name)
    {
        _armorType = "helmet";
        _defense = 0;
    }
    public Armor() 
    {
        _armorType = "helmet";
        _defense = 0;
    }
    public string GetArmorType()
    {
        return _armorType;
    }
    public void SetArmorType(string armorType)
    {
        _armorType = armorType;
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
        Console.WriteLine($"Name: {GetName()} || {GetDescription()} || Weight: {GetWeight()} ");
        Console.WriteLine($"Type: {_armorType} || Defense: {_defense}\n");
    }
        public string ArmorToString()
    {
        return $"Armor||{GetName()}||{GetDescription()}||{GetWeight()}||{GetStackable()}||{_armorType}||{_defense}";
    }
}