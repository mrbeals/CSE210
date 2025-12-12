public class KeyItemInventory : Storage
{
    List<KeyItems> _keyItemInventory = new List<KeyItems>();


    public KeyItemInventory(int maxSlots, List<KeyItems> keyItemInventory) : base(maxSlots)
    {
        _keyItemInventory = keyItemInventory;
    }
    public KeyItemInventory(int maxSlots) : base(maxSlots)
    {
         _keyItemInventory = [];
    }
    public KeyItemInventory() 
    {
        _keyItemInventory = [];
    }

    public override void Discard(Items item)
    {
        Console.WriteLine($"You cannot Discard a Key item, even if you dont want {item}");
    }
    public override void Display()
    {
        
    }
    public void AddToKeyItems(KeyItems keyitem)
    {
        _keyItemInventory.Add(keyitem);
    }
}