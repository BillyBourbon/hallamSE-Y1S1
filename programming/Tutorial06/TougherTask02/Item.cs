class Item
{
    public string name;
    public int quantity = 1;
    public bool isTicked = true;
    public int index = -1;

    public Item(string itemName)
    {
        name = itemName;
    }
    public Item(string itemName, int itemQuantity)
    {
        name = itemName;
        quantity = itemQuantity;
    }

    public void SetQuantity(int itemQuantity)
    {
        quantity = itemQuantity;
    }
}
