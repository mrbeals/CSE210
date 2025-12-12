using System.Diagnostics.Metrics;
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
        _bank = new List<Items>();
    }
    public Bank()
    {
        _bank = new List<Items>();
    }
    public override void Display()
    {
        int counter = 0;
        foreach (Items I in _bank)
        {
            if (I.GetStackable() && I is Consumable c)
            {
                Console.Write($"[{I.GetName}x{c.GetQuantity()}] ");
                counter += 1;
                if (counter % 10 == 0)
                {
                    Console.Write($"\n");
                }
            }
            else {
            Console.Write($"[{I.GetName()}] ");
            counter += 1;
            if (counter % 10 == 0)
            {
                Console.Write($"\n");
            }
            }
        }
        Console.WriteLine("");
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
    public List<Items> GetBank()
    {
        return _bank;
    }
        public Items FindItem(string name)
    {
        foreach (Items i in _bank)
        {
            if (i.GetName() == name)
            {
              return i;  
            }
        }
        return null;
    }
}