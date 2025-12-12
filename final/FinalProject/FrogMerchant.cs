public class FrogMerchant
{
    private List<Items> _itemList = new List<Items>();

    public List<Items> GetItemList()
    {
        return _itemList;
    }
    public void AddtoItemList(Items item)
    {
        _itemList.Add(item);
    }
    public void DisplayMerchant()
    {
        Console.Write("      __    __\n     ( o \\/ o )\n     /        \\\n    |    ..    |\n    |  .____.  |\n     \\________/\n     /  |  |  \\\n    /___|__|___\\\n       /____\\\n");
    }
    private Items GetRandomItem()
    {
        Random randomness = new Random();
        int length = _itemList.Count();
        int randomIndex = randomness.Next(0, length);

        return _itemList[randomIndex];
    }
    public void ItemAquire(Inventory inventory, KeyItemInventory keyItemInventory)
    {
        Console.Clear();
        DisplayMerchant();
        if (_itemList.Count() == 0)
        {
            Console.WriteLine("I have no items yet :) ");
            Console.Write("Press enter to return. ");
            Console.ReadLine();
        }
        else
        {
        Items item = GetRandomItem();
        Console.WriteLine($"I seem to have this {item} here for you. it is described as '{item.GetDescription()}'");
        Console.Write("Would you like this item? (y/n) ");
        string answer = Console.ReadLine();
        if (answer.ToLower() == "y")
        {        
            if (item is KeyItems k)
            {
                keyItemInventory.AddToKeyItems(k);
            }
            else
            {
                if (inventory.CheckWeight(item.GetWeight()) && inventory.CheckSize())
                {
                    inventory.AddToInventory(item);
            
                } else {Console.WriteLine("Could not complete transfer, please check inventory.");}
            }
        }
        else
        {
            Console.WriteLine("Well next time I hope I can peak your interest.");
        }
    }
    }
}