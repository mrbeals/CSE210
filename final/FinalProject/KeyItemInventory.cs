public class KeyItemInventory : Storage
{
    List<KeyItems> _keyItemInventory = new List<KeyItems>();


    public KeyItemInventory(int maxSlots, List<KeyItems> keyItemInventory) : base(maxSlots)
    {
        _keyItemInventory = keyItemInventory;
    }
    public KeyItemInventory(int maxSlots) : base(maxSlots)
    {
         _keyItemInventory = new List<KeyItems>();
    }
    public KeyItemInventory() 
    {
        _keyItemInventory = new List<KeyItems>();
    }

    public override void Discard(Items item)
    {
        Console.WriteLine($"You cannot Discard a Key item, even if you dont want {item}");
    }
    public override void Display()
    {
        int counter = 0;
        foreach (Items I in _keyItemInventory)
        {
            
            Console.Write($"[{I.GetName}] ");
            counter += 1;
            if (counter % 5 == 0)
            {
                Console.Write($"\n");
            }
        }
        Console.WriteLine("");
    }
    public void AddToKeyItems(KeyItems keyitem)
    {
        _keyItemInventory.Add(keyitem);
    }
        public List<KeyItems> GetKeyItemInventory()
    {
        return _keyItemInventory;
    }
}