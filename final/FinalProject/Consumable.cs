using System.Runtime.InteropServices;

public class Consumable : Items
{
    private int _damage = 0;
    private int _quantity = 0;
    private int _healAmount = 0;

    public Consumable(string name, string description, int weight, Boolean stackable, int damage, int quantity, int healAmount) : base(name, description, weight, stackable)
    {
    _damage = damage;
    _quantity = quantity;
    _healAmount = healAmount;
    }
    public Consumable(string name, string description, int weight, Boolean stackable, int quantity, int healAmount) : base(name, description, weight, stackable)
    {
        _damage = 0;
        _quantity = quantity;
        _healAmount = healAmount;
    }
    public Consumable(string name, string description, int weight, Boolean stackable, int quantity) : base(name, description, weight, stackable)
    {
        _damage = 0;
        _quantity = quantity;
        _healAmount = 0;
    }
    public Consumable(string name, string description, int weight, Boolean stackable) : base(name, description, weight, stackable)
    {
        _damage = 0;
        _quantity = 0;
        _healAmount = 0;
    }
    public Consumable(string name, string description, int weight) : base(name, description, weight)
    {
        _damage = 0;
        _quantity = 0;
        _healAmount = 0;
    }
    public Consumable(string name, string description) : base(name, description)
    {
        _damage = 0;
        _quantity = 0;
        _healAmount = 0;
    }
    public Consumable(string name, int weight) : base(name, weight)
    {
        _damage = 0;
        _quantity = 0;
        _healAmount = 0;
    }
    public Consumable(string name, Boolean stackable) : base(name, stackable)
    {
        _damage = 0;
        _quantity = 0;
        _healAmount = 0;
    }
    public Consumable(string name) : base(name)
    {
        _damage = 0;
        _quantity = 0;
        _healAmount = 0;
    }
    public Consumable() 
    {
        _damage = 0;
        _quantity = 0;
        _healAmount = 0;
    }

    public void UseConsumable()
    {
        _quantity -= 1;
        Console.WriteLine($"Used one {GetName()}, did {_damage} damage, Healed {_healAmount}, {_quantity} remaining");
    }
    public override void Display()
    {
        Console.WriteLine($"Name: {GetName()} || {GetDescription()} || Weight: {GetWeight()} ");
        Console.WriteLine($"Quantity: {_quantity} || Damage: {_damage} || Heal Amount: {_healAmount}\n");
    }
    public int GetDaamge()
    {
        return _damage;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public int GetHealAmount()
    {
        return _healAmount;
    }
    public void AddQuantity(int amount)
    {
        _quantity += amount;
    }
    public void Setdamage(int damage)
    {
        _damage = damage;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
    public void SetHealAmount(int healAmount)
    {
        _healAmount = healAmount;
    }
        public string ConsumableToString()
    {
        return $"Consumables||{GetName()}||{GetDescription()}||{GetWeight()}||{GetStackable()}||{_damage}||{_quantity}||{_healAmount}";
    }
}