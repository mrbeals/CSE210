using System;
using System.ComponentModel;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;


class Program
{
    static void Main(string[] args)
    {

        FrogMerchant frogMerchant = new FrogMerchant();
        Inventory inventory = new Inventory(28, 100);
        Bank bank = new Bank();
        KeyItemInventory keyItemInventory = new KeyItemInventory();
        int choice = 0;
        while (choice != 8)
        {
            Console.Clear();
            Console.WriteLine("1. Interact with the Frog Merchant.");
            Console.WriteLine("2. Add item to possible items.");
            Console.WriteLine("3. Manage inventory.");
            Console.WriteLine("4. Manage Bank.");
            Console.WriteLine("5. View Key Items");
            Console.WriteLine("6. Save.");
            Console.WriteLine("7. Load");
            Console.WriteLine("8. Quit");
            Console.Write("What would you pick? ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                VisitTheFrogmerchant(frogMerchant, inventory, keyItemInventory);
            }
            else if (choice == 2)
            {
                AddToFrog(frogMerchant);
            }
            else if (choice == 3)
            {
                InventoryMenu(inventory, bank);
            }
            else if (choice == 4)
            {
                BankMenu(bank, inventory);
            }
            else if (choice == 5)
            {
                ViewKeyItems(keyItemInventory);
            }
            else if (choice == 6)
            {
                Save(frogMerchant, inventory, bank, keyItemInventory);
            }
            else if (choice == 7)
            {
                Load(frogMerchant, inventory, bank, keyItemInventory);
            }

        }
    }


    static void AddToFrog(FrogMerchant frogMerchant)
    {
       Console.Clear();
       Console.WriteLine("1. Weapon");
       Console.WriteLine("2. Armor");
       Console.WriteLine("3. Consumable");
       Console.WriteLine("4. KeyItems");
       Console.Write("What type of Item would you like to add? ");
       int first = int.Parse(Console.ReadLine());

       if (first == 1)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Description: ");
            string description = Console.ReadLine();
            Console.Write("Weight: ");
            int weight = int.Parse(Console.ReadLine());
            Console.Write("Stackable: (y/n) ");
            string bool1 = Console.ReadLine();
            Boolean stackable = false;
            if (bool1.ToLower() == "y")
                {
                    stackable = true;
                }
                else
                {
                    stackable = false;
                }
            Console.Write("Damage: ");
            int damage = int.Parse(Console.ReadLine());
            Console.Write("Weapon Type: ");
            string weaponType = Console.ReadLine();
            Console.Write("Defense: ");
            int defense = int.Parse(Console.ReadLine());
            Console.Write("Needs Projectiles? (y/n) ");
            string bool2 = Console.ReadLine();
            Boolean needsProjectiles = false;
            if (bool2.ToLower() == "y")
                {
                    needsProjectiles = true;
                }
                else
                {
                    needsProjectiles = false;
                }           
            Console.Write("Hand: ");
            string hand = Console.ReadLine();
            Weapon weapon = new Weapon(name, description, weight, stackable, damage, weaponType, defense, needsProjectiles, hand);
            frogMerchant.AddtoItemList(weapon);
        }
        else if (first == 2)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Description: ");
            string description = Console.ReadLine();
            Console.Write("Weight: ");
            int weight = int.Parse(Console.ReadLine());
            Console.Write("Stackable: (y/n) ");
            string bool1 = Console.ReadLine();
            Boolean stackable = false;
            if (bool1.ToLower() == "y")
                {
                    stackable = true;
                }
                else
                {
                    stackable = false;
                }
            Console.Write("Armor Type: ");
            string armorType = Console.ReadLine();
            Console.Write("Defense: ");
            int defense = int.Parse(Console.ReadLine());   
            Armor armor = new Armor(name, description, weight, stackable, armorType, defense);
            frogMerchant.AddtoItemList(armor);         
        }
        else if (first == 3)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Description: ");
            string description = Console.ReadLine();
            Console.Write("Weight: ");
            int weight = int.Parse(Console.ReadLine());
            Console.Write("Stackable: (y/n) ");
            string bool1 = Console.ReadLine();
            Boolean stackable = false;
            if (bool1.ToLower() == "y")
                {
                    stackable = true;
                }
                else
                {
                    stackable = false;
                }
            Console.Write("Damage: ");
            int damage = int.Parse(Console.ReadLine());
            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());
            Console.Write("Heal Amount: ");
            int healAmount = int.Parse(Console.ReadLine());
            Consumable consumable = new Consumable(name, description, weight, stackable, damage, quantity, healAmount);
            frogMerchant.AddtoItemList(consumable);
        }
        else if (first == 4)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Description: ");
            string description = Console.ReadLine();
            Console.Write("Weight: ");
            int weight = int.Parse(Console.ReadLine());
            Console.Write("Stackable: (y/n) ");
            string bool1 = Console.ReadLine();
            Boolean stackable = false;
            if (bool1.ToLower() == "y")
                {
                    stackable = true;
                }
                else
                {
                    stackable = false;
                }
            Console.Write("Effect: ");
            string effect = Console.ReadLine();
            KeyItems keyItems = new KeyItems(name, description, weight, stackable, effect);
            frogMerchant.AddtoItemList(keyItems);            
        }
        Console.WriteLine("Item added Successfully!");
        Console.Write("Press enter to return. ");
        Console.ReadLine();


    }
    static void VisitTheFrogmerchant(FrogMerchant frogMerchant, Inventory inventory, KeyItemInventory keyItemInventory)
    {
        frogMerchant.ItemAquire(inventory, keyItemInventory);
    }
    static void Load(FrogMerchant frogMerchant, Inventory inventory, Bank bank, KeyItemInventory keyItemInventory)
    {
       string[] lines = System.IO.File.ReadAllLines("frogmerchant.txt");

        foreach (string line in lines)
        {
            string[] parts = line.Split("||");

            string type = parts[0];

            if (type == "Weapon")
            {
                Boolean parts4 = false;
                Boolean parts8 = false;
                if (parts[4].ToLower() == "true")
                    {
                        parts4 = true;
                    }
                    else
                    {
                        parts4 = false;
                    }
                if (parts[8].ToLower() == "true")
                    {
                        parts8 = true;
                    }
                    else
                    {
                        parts8 = false;
                    }
                Weapon weapon = new Weapon(parts[1], parts[2],int.Parse(parts[3]), parts4,int.Parse(parts[5]), parts[6], int.Parse(parts[7]), parts8,parts[9]);
                frogMerchant.AddtoItemList(weapon);
            }
            else if (type == "Armor")
            {
                Boolean parts4 = false;
                
                if (parts[4].ToLower() == "true")
                    {
                        parts4 = true;
                    }
                    else
                    {
                        parts4 = false;
                    }
                Armor armor = new Armor(parts[1], parts[2],int.Parse(parts[3]), parts4, parts[5], int.Parse(parts[6]));
                frogMerchant.AddtoItemList(armor);
            }
            else if (type == "Consumable")
            {
                Boolean parts4 = false;
                
                if (parts[4].ToLower() == "true")
                    {
                        parts4 = true;
                    }
                    else
                    {
                        parts4 = false;
                    }
                Consumable consumable = new Consumable(parts[1], parts[2],int.Parse(parts[3]), parts4, int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]));
                frogMerchant.AddtoItemList(consumable);
            }
            else if (type == "KeyItems")
            {
                Boolean parts4 = false;
                
                if (parts[4].ToLower() == "true")
                    {
                        parts4 = true;
                    }
                    else
                    {
                        parts4 = false;
                    }
                KeyItems keyitem = new KeyItems(parts[1], parts[2],int.Parse(parts[3]), parts4, parts[5]);
                frogMerchant.AddtoItemList(keyitem);
            }
        }
        string[] lines2 = System.IO.File.ReadAllLines("bank.txt");

        foreach (string line in lines2)
        {
            string[] parts = line.Split("||");

            string type = parts[0];

            if (type == "Weapon")
            {
                Boolean parts4 = false;
                Boolean parts8 = false;
                if (parts[4].ToLower() == "true")
                    {
                        parts4 = true;
                    }
                    else
                    {
                        parts4 = false;
                    }
                if (parts[8].ToLower() == "true")
                    {
                        parts8 = true;
                    }
                    else
                    {
                        parts8 = false;
                    }
                Weapon weapon = new Weapon(parts[1], parts[2],int.Parse(parts[3]), parts4,int.Parse(parts[5]), parts[6], int.Parse(parts[7]), parts8,parts[9]);
                bank.AddToBank(weapon);
            }
            else if (type == "Armor")
            {
                Boolean parts4 = false;
                
                if (parts[4].ToLower() == "true")
                    {
                        parts4 = true;
                    }
                    else
                    {
                        parts4 = false;
                    }
                Armor armor = new Armor(parts[1], parts[2],int.Parse(parts[3]), parts4, parts[5], int.Parse(parts[6]));
                bank.AddToBank(armor);
            }
            else if (type == "Consumable")
            {
                Boolean parts4 = false;
                
                if (parts[4].ToLower() == "true")
                    {
                        parts4 = true;
                    }
                    else
                    {
                        parts4 = false;
                    }
                Consumable consumable = new Consumable(parts[1], parts[2],int.Parse(parts[3]), parts4, int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]));
                bank.AddToBank(consumable);
            }
            else if (type == "KeyItems")
            {
                Boolean parts4 = false;
                
                if (parts[4].ToLower() == "true")
                    {
                        parts4 = true;
                    }
                    else
                    {
                        parts4 = false;
                    }
                KeyItems keyitem = new KeyItems(parts[1], parts[2],int.Parse(parts[3]), parts4, parts[5]);
                bank.AddToBank(keyitem);
            }
        }
        string[] lines3 = System.IO.File.ReadAllLines("inventory.txt");

        foreach (string line in lines3)
        {
            string[] parts = line.Split("||");

            string type = parts[0];

            if (type == "Weapon")
            {
                Boolean parts4 = false;
                Boolean parts8 = false;
                if (parts[4].ToLower() == "true")
                    {
                        parts4 = true;
                    }
                    else
                    {
                        parts4 = false;
                    }
                if (parts[8].ToLower() == "true")
                    {
                        parts8 = true;
                    }
                    else
                    {
                        parts8 = false;
                    }
                Weapon weapon = new Weapon(parts[1], parts[2],int.Parse(parts[3]), parts4,int.Parse(parts[5]), parts[6], int.Parse(parts[7]), parts8,parts[9]);
                inventory.AddToInventory(weapon);
            }
            else if (type == "Armor")
            {
                Boolean parts4 = false;
                
                if (parts[4].ToLower() == "true")
                    {
                        parts4 = true;
                    }
                    else
                    {
                        parts4 = false;
                    }
                Armor armor = new Armor(parts[1], parts[2],int.Parse(parts[3]), parts4, parts[5], int.Parse(parts[6]));
                inventory.AddToInventory(armor);
            }
            else if (type == "Consumable")
            {
                Boolean parts4 = false;
                
                if (parts[4].ToLower() == "true")
                    {
                        parts4 = true;
                    }
                    else
                    {
                        parts4 = false;
                    }
                Consumable consumable = new Consumable(parts[1], parts[2],int.Parse(parts[3]), parts4, int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]));
                inventory.AddToInventory(consumable);
            }
            else if (type == "KeyItems")
            {
                Boolean parts4 = false;
                
                if (parts[4].ToLower() == "true")
                    {
                        parts4 = true;
                    }
                    else
                    {
                        parts4 = false;
                    }
                KeyItems keyitem = new KeyItems(parts[1], parts[2],int.Parse(parts[3]), parts4, parts[5]);
                inventory.AddToInventory(keyitem);
            }
        }
        string[] lines4 = System.IO.File.ReadAllLines("keyiteminventory.txt");

        foreach (string line in lines4)
        {
            string[] parts = line.Split("||");
            Boolean parts4 = false;
                
            if (parts[4].ToLower() == "true")
                {
                    parts4 = true;
                }
                else
                {
                    parts4 = false;
                }
                KeyItems keyitem = new KeyItems(parts[1], parts[2],int.Parse(parts[3]), parts4, parts[5]);
                keyItemInventory.AddToKeyItems(keyitem);
        }
        }

    static void Save(FrogMerchant frogmerchant, Inventory inventory, Bank bank, KeyItemInventory keyItemInventory)
    {
        
        using (StreamWriter outputFile = new StreamWriter("frogmerchant.txt"))
        {
            foreach (Items i in frogmerchant.GetItemList())
            {
                if (i is Weapon w){
                    outputFile.WriteLine(w.WeaponToString());
                }
                else if  (i is Consumable c)
                {
                    outputFile.WriteLine(c.ConsumableToString());
                }
                else if (i is Armor a)
                {
                    outputFile.WriteLine(a.ArmorToString());
                }
                else if (i is KeyItems k)
                {
                    outputFile.WriteLine(k.KeyItemToString());
                }
            }
        }
        using (StreamWriter outputFile = new StreamWriter("bank.txt"))
        {
            foreach (Items i in bank.GetBank())
            {
                if (i is Weapon w){
                    outputFile.WriteLine(w.WeaponToString());
                }
                else if  (i is Consumable c)
                {
                    outputFile.WriteLine(c.ConsumableToString());
                }
                else if (i is Armor a)
                {
                    outputFile.WriteLine(a.ArmorToString());
                }
                else if (i is KeyItems k)
                {
                    outputFile.WriteLine(k.KeyItemToString());
                }
            }
        }
        using (StreamWriter outputFile = new StreamWriter("inventory.txt"))
        {
            foreach (Items i in inventory.GetInventory())
            {
                if (i is Weapon w){
                    outputFile.WriteLine(w.WeaponToString());
                }
                else if  (i is Consumable c)
                {
                    outputFile.WriteLine(c.ConsumableToString());
                }
                else if (i is Armor a)
                {
                    outputFile.WriteLine(a.ArmorToString());
                }
                else if (i is KeyItems k)
                {
                    outputFile.WriteLine(k.KeyItemToString());
                }
            }
        }     
        using (StreamWriter outputFile = new StreamWriter("keyiteminventory.txt"))
        {
            foreach (Items i in keyItemInventory.GetKeyItemInventory())
            {
                if (i is Weapon w){
                    outputFile.WriteLine(w.WeaponToString());
                }
                else if  (i is Consumable c)
                {
                    outputFile.WriteLine(c.ConsumableToString());
                }
                else if (i is Armor a)
                {
                    outputFile.WriteLine(a.ArmorToString());
                }
                else if (i is KeyItems k)
                {
                    outputFile.WriteLine(k.KeyItemToString());
                }
            }
        }                 
    }
    static void InventoryMenu(Inventory inventory, Bank bank)
    {
        int choice = 0;
        while (choice != 4) 
        {
            Console.Clear();
            inventory.Display();
            inventory.DisplaySize();
            inventory.DisplayWeight();
            Console.WriteLine("");
            Console.WriteLine("-- Inventory menu --");
            Console.WriteLine("1. Display Weights");
            Console.WriteLine("2. Move Items to Bank");
            Console.WriteLine("3. Discard items");
            Console.WriteLine("4. Return");
            Console.Write("Which would you like? ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Clear();
                inventory.DisplayItemWeights();
                Console.ReadLine();
            }
            else if (choice == 2)
            {
                Console.Clear();
                inventory.Display();
                inventory.DisplaySize();
                inventory.DisplayWeight();
                Console.Write("What item to move? ");
                string move = Console.ReadLine();
                Items foundItem = inventory.FindItem(move);
                if (foundItem != null)
                {
                    inventory.InventoryToBank(foundItem, bank);
                }
                else
                {
                    Console.WriteLine("Could not find Item");
                }
                
            }
            else if (choice == 3)
            {
                Console.Clear();
                inventory.Display();
                inventory.DisplaySize();
                inventory.DisplayWeight();
                Console.Write("What item to discard? ");
                string discard = Console.ReadLine();
                Items foundItem = inventory.FindItem(discard);
                if (foundItem != null)
                {
                    inventory.Discard(foundItem);
                }
                else
                {
                    Console.WriteLine("Could not find Item");
                }
            }
        }

    }
    static void BankMenu(Bank bank, Inventory inventory)
    {
        int choice = 0;
        while (choice != 3) 
        {
            Console.Clear();
            bank.Display();

            Console.WriteLine("");
            Console.WriteLine("-- Bank menu --");
            Console.WriteLine("1. Move Items to Bank");
            Console.WriteLine("2. Discard items");
            Console.WriteLine("3. Return");
            Console.Write("Which would you like? ");
            choice = int.Parse(Console.ReadLine());


            if (choice == 1)
            {
                Console.Clear();
                bank.Display();

                Console.Write("What item to move? ");
                string move = Console.ReadLine();
                Items foundItem = bank.FindItem(move);
                if (foundItem != null)
                {
                    bank.BankToInventory(foundItem, inventory);
                }
                else
                {
                    Console.WriteLine("Could not find Item");
                }
                
            }
            else if (choice == 2)
            {
                Console.Clear();
                bank.Display();
                Console.Write("What item to discard? ");
                string discard = Console.ReadLine();
                Items foundItem = bank.FindItem(discard);
                if (foundItem != null)
                {
                    bank.Discard(foundItem);
                }
                else
                {
                    Console.WriteLine("Could not find Item");
                }
            }
        }

    }
    static void ViewKeyItems(KeyItemInventory keyItemInventory)
    {
        Console.Clear();
        keyItemInventory.Display();
        Console.ReadLine();
    }
}