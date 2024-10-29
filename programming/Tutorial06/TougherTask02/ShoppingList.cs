class ShoppingList
{
    public List<Item> items = new List<Item>();

    public void AddItem(string itemName, int itemQuantity = 1)
    {
        Item item = new Item(itemName, itemQuantity);
        Item existingItem = FindItem(item);
        if (IsItemPresent(existingItem))
        {
            existingItem.isTicked = false;
        }
        else
        {
            items.Add(item);
        }
    }

    public void RemoveItem(string itemName)
    {
        int indexToDelete = FindItem(new Item(itemName)).index;
        items.RemoveAt(indexToDelete);
    }

    public Item FindItem(Item searchItem)
    {
        int index = 0;
        foreach (Item item in items)
        {
            if (item.name == searchItem.name)
            {
                item.index = index;
                return item;
            }
            index++;
        }
        return searchItem;
    }
    public Item FindItem(string itemName)
    {
        int index = 0;
        foreach (Item item in items)
        {
            if (item.name == itemName)
            {
                item.index = index;
                return item;
            }
            index++;
        }
        return new Item(itemName);
    }

    public bool IsItemPresent(Item i)
    {
        Item item = FindItem(i);
        if (item.index >= 0) return true;
        return false;
    }
    public bool IsItemPresent(string itemName)
    {
        Item item = FindItem(itemName);
        if (item.index >= 0) return true;
        return false;
    }
    public void TickoffItem(string itemName)
    {
        Item searchItem = new Item(itemName);
        int index = FindItem(searchItem).index;
        if (index >= 0)
        {
            items[index].isTicked = false;
        }
    }
    public void DisplayList()
    {
        //Console.Clear();
        Console.WriteLine("Starting List Output");
        Console.WriteLine();
        Console.WriteLine("       Item Name       Quantity");
        foreach (Item item in items) 
        {
            string check = " ";
            if (item.isTicked) check = "x";
            Console.WriteLine($"[{check}]    {item.name}             {item.quantity}");
            //Console.WriteLine($"Name: {item.name}, IsTicked: {item.isTicked}, Index: {item.index}");        
        };
    }
}
