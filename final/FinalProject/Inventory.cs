public class Inventory :  Storage
{
    private int _maxWeight = 0;
    private int _currentWeight = 0;
    private List<Items> _inventory = new List<Items>();

    public Inventory(int maxSlots, int maxWeight, int currentWeight, List<Items> inventory) : base(maxSlots)
    {
        _maxWeight = maxWeight;
        _currentWeight = currentWeight;
        _inventory = inventory;

    }
    public Inventory(int maxSlots, int maxWeight, int currentWeight) : base(maxSlots)
    {
        _maxWeight = maxWeight;
        _currentWeight = currentWeight;
        _inventory = new List<Items>();
    }
    public Inventory(int maxSlots, int maxWeight, List<Items> inventory) : base(maxSlots)
    {
        _maxWeight = maxWeight;
        _currentWeight = GetCurrentWeight();
        _inventory = inventory;
    }
    public Inventory(int maxSlots, int maxWeight) : base(maxSlots)
    {
        _maxWeight = maxWeight;
        _currentWeight = GetCurrentWeight();
        _inventory = new List<Items>();
    }
    public Inventory(int maxSlots, List<Items> inventory) : base(maxSlots)
    {
        _maxWeight = 100;
        _currentWeight = GetCurrentWeight();
        _inventory = inventory;
    }
    public Inventory(int maxSlots) : base(maxSlots) 
    {
        _maxWeight = 100;
        _currentWeight = GetCurrentWeight();
        _inventory = new List<Items>();
    }

    public Inventory() 
    {
        _maxWeight = 100;
        _currentWeight = GetCurrentWeight();
        _inventory = new List<Items>();
    }
    public int GetCurrentWeight()
    {
        int totalWeight = 0;
        foreach (Items i in _inventory)
        {
            totalWeight += i.GetWeight();
        }
        return totalWeight;
    }   

    public void AddToInventory(Items item)
    {
        _inventory.Add(item);
        _currentWeight = GetCurrentWeight();
    }
    public override void Discard(Items item)
    {
        _inventory.Remove(item);
    }

    public void InventoryToBank(Items item, Bank bank)
    {
        bank.AddToBank(item);
        Discard(item);
        _currentWeight = GetCurrentWeight();
    }
    public int GetMaxWeight()
    {
        return _maxWeight;
    }
    public void SetMaxWeight(int maxWeight)
    {
        _maxWeight = maxWeight;
    }
    public override void Display()
    {    
        int counter = 0;
        foreach (Items I in _inventory)
        {
            if (I.GetStackable() && I is Consumable c)
            {
                Console.Write($"[{I.GetName}x{c.GetQuantity()}] ");
                counter += 1;
                if (counter % 7 == 0)
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
    public Boolean CheckWeight(int weight)
    {
        if (_currentWeight + weight > _maxWeight)
        {
            Console.Write("Weight too much");
            return false;
        } else {return true;}
    }
    public Boolean CheckSize()
    {
        if (_inventory.Count < GetMaxSlots())
        {
            return true;
        } else
        {
            Console.WriteLine("Inventory Full");
            return false;
        }
    }
    public void DisplaySize()
    {
        Console.WriteLine($"{_inventory.Count}/{GetMaxSlots()}");
    }
    public void DisplayWeight()
    {
        Console.WriteLine($"{_currentWeight}/{_maxWeight}");
    }
    public void DisplayItemWeights()
    {
        DisplayWeight();
        foreach (Items I in _inventory)
        {
            Console.WriteLine($"{I.GetName()} : {I.GetWeight()}");
        }
    }
        public List<Items> GetInventory()
    {
        return _inventory;
    }
    public Items FindItem(string name)
    {
        foreach (Items i in _inventory)
        {
            if (i.GetName() == name)
            {
              return i;  
            }
        }
        return null;
    }
    }