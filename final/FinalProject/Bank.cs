using System.Runtime.CompilerServices;

public class Bank : Storage
{
    private List<Items> _bank = new List<Items>();

    public Bank(int maxSlots, List<Items> bank) : base(maxSlots)
    {
        _bank = bank;
    }
    public Bank(int maxSlots) : base(maxSlots)
    {
        _bank = [];
    }
    public Bank()
    {
        _bank = [];
    }
    public override void Display()
    {

    }
    public override void Discard(Items item)
    {
        RemoveFromBank(item);
    }

    public void BankToInventory(Items item, Inventory i)
    {
        if (i.CheckWeight(item.GetWeight()) && i.CheckSize())
        {
            RemoveFromBank(item);
            i.AddToInventory(item);
            
        } else {Console.WriteLine("Could not complete transfer, please check inventory.");}
    }
    public void AddToBank(Items item)
    {
        _bank.Add(item);
    }
    public void RemoveFromBank(Items item)
    {
        _bank.Remove(item);
    }
}