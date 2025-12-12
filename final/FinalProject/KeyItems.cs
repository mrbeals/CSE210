public class KeyItems : Items
{
    private string _effect = "";

    public KeyItems(string name, string description, int weight, Boolean stackable, string effect) : base(name, description, weight, stackable)
    {
        _effect = effect;
    }
    public KeyItems(string name, string description, int weight, string effect) : base(name, description, weight)
    {
        _effect = effect;        
    }
    public KeyItems(string name, string description, string effect) : base(name, description)
    {
        _effect = effect;        
    }
    public KeyItems(string name, string description, int weight, Boolean stackable) : base(name, description, weight, stackable)
    {
        _effect = "Something cool I guess";        
    }
    public KeyItems(string name, string description, int weight) : base(name, description, weight)
    {
        _effect = "Something cool I guess";         
    }
    public KeyItems(string name, string description) : base(name, description)
    {
        _effect = "Something cool I guess"; 
    }
    public KeyItems(string name, int weight) : base(name, weight)
    {
        _effect = "Something cool I guess"; 
    }
    public KeyItems(string name, Boolean stackable) : base(name, stackable)
    {
        _effect = "Something cool I guess"; 
    }
    public KeyItems(string name) : base(name)
    {
        _effect = "Something cool I guess"; 
    }
    public KeyItems() 
    {
        _effect = "Something cool I guess"; 
    }



    public void UseEffect()
    {
        
    }
    public void SetEffect(string effect)
    {
        _effect = effect;
    }
    public string GetEffect()
    {
        return _effect;
    }
    public override void Display()
    {
        Console.WriteLine($"Name: {GetName()} || {GetDescription()} || Weight: {GetWeight()} ");
        Console.WriteLine($"Effect: {_effect}\n");
    }
        public string KeyItemToString()
    {
        return $"KeyItems||{GetName()}||{GetDescription()}||{GetWeight()}||{GetStackable()}||{_effect}";
    }
}