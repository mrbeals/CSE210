public class Weapon : Items
{
    private int _damage = 0;
    private string _weaponClass = "";
    private int _defense = 0;
    private Boolean _requireProjectile = false;
    private string _hand = "";

    public Weapon(string name, string description, int weight, Boolean stackable, int damage, string weaponClass, int defense, Boolean requireProjectile, string hand) : base(name, description, weight, stackable)
    {
        _damage = damage;
        _weaponClass = weaponClass;
        _defense = defense;
        _requireProjectile = requireProjectile;
        _hand = hand;
    }
    public Weapon(string name, string description, int weight, Boolean stackable, int damage, string weaponClass, int defense, Boolean requireProjectile) : base(name, description, weight, stackable)
    {
        _damage = damage;
        _weaponClass = weaponClass;
        _defense = defense;
        _requireProjectile = requireProjectile;
        _hand = "right";
    }
    public Weapon(string name, string description, int weight, Boolean stackable, int damage, string weaponClass, int defense) : base(name, description, weight, stackable)
    {
        _damage = damage;
        _weaponClass = weaponClass;
        _defense = defense;
        _requireProjectile = false;
        _hand = "right";
    }
    public Weapon(string name, string description, int weight, Boolean stackable, int damage, string weaponClass) : base(name, description, weight, stackable)
    {
        _damage = damage;
        _weaponClass = weaponClass;
        _defense = 0;
        _requireProjectile = false;
        _hand = "right";
    }
    public Weapon(string name, string description, int weight, Boolean stackable, int damage) : base(name, description, weight, stackable)
    {
        _damage = damage;
        _weaponClass = "axe";
        _defense = 0;
        _requireProjectile = false;
        _hand = "right";
    }
    public Weapon(string name, string description, int weight, Boolean stackable, int damage, string weaponClass, int defense, string hand) : base(name, description, weight, stackable)
    {
        _damage = damage;
        _weaponClass = weaponClass;
        _defense = defense;
        _requireProjectile = false;
        _hand = hand;
    }
    public Weapon(string name, string description, int weight, Boolean stackable, int damage, string weaponClass, string hand) : base(name, description, weight, stackable)
    {
        _damage = damage;
        _weaponClass = weaponClass;
        _defense = 0;
        _requireProjectile = false;
        _hand = hand;
    }

    public Weapon(string name, string description, int weight, Boolean stackable, string hand) : base(name, description, weight, stackable)
    {
        _damage = 0;
        _weaponClass = "axe";
        _defense = 0;
        _requireProjectile = false;
        _hand = hand;
    }
    public Weapon(string name, string description, int weight, Boolean stackable, int damage, string weaponClass, Boolean requireProjectile) : base(name, description, weight, stackable)
    {
        _damage = damage;
        _weaponClass = weaponClass;
        _defense = 0;
        _requireProjectile = requireProjectile;
        _hand = "right";
    }
    public Weapon(string name, string description, int weight, Boolean stackable, int damage, Boolean requireProjectile, string hand) : base(name, description, weight, stackable)
    {
        _damage = damage;
        _weaponClass = "axe";
        _defense = 0;
        _requireProjectile = requireProjectile;
        _hand = hand;
    }
    public Weapon(string name, string description, int weight, Boolean stackable, string weaponClass, int defense, Boolean requireProjectile, string hand) : base(name, description, weight, stackable)
    {
        _damage = 0;
        _weaponClass = weaponClass;
        _defense = defense;
        _requireProjectile = requireProjectile;
        _hand = hand;
    }

    public Weapon(string name, string description, int weight) : base(name, description, weight)
    {
        _damage = 0;
        _weaponClass = "axe";
        _defense = 0;
        _requireProjectile = false;
        _hand = "right";
    }
    public Weapon(string name, string description) : base(name, description)
    {
        _damage = 0;
        _weaponClass = "axe";
        _defense = 0;
        _requireProjectile = false;
        _hand = "right";
    }
    public Weapon(string name, int weight) : base(name, weight)
    {
        _damage = 0;
        _weaponClass = "axe";
        _defense = 0;
        _requireProjectile = false;
        _hand = "right";
    }
    public Weapon(string name, Boolean stackable) : base(name, stackable)
    {
        _damage = 0;
        _weaponClass = "axe";
        _defense = 0;
        _requireProjectile = false;
        _hand = "right";
    }
    public Weapon(string name) : base(name)
    {
        _damage = 0;
        _weaponClass = "axe";
        _defense = 0;
        _requireProjectile = false;
        _hand = "right";
    }
    public Weapon() 
    {
        _damage = 0;
        _weaponClass = "axe";
        _defense = 0;
        _requireProjectile = false;
        _hand = "right";
    }
    public int GetDamage()
    {
        return _damage;
    }
    public  void SetDamage(int damage)
    {
        _damage = damage;
    }
    public void SetWeaponClass(string weaponClass)
    {
        _weaponClass = weaponClass;
    }

    public string GetWeaponClass()
    {
        return _weaponClass;
    }
    public int GetDefense()
    {
        return _defense;
    }
    public void SetDefense(int defense)
    {
        _defense = defense;
    }
    public Boolean GetRequireProjectile()
    {
        return _requireProjectile;
    }
    public void SetRequireProjectile(Boolean requireProjectile)
    {
        _requireProjectile = requireProjectile;
    }
    public string GetHand()
    {
        return _hand;
    }
    public void SetHand(string hand)
    {
        _hand = hand;
    }
    public override void Display()
    {
        
    }
}

