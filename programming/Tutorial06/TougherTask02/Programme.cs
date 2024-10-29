//Write and test a ShoppingList class used to represent and manage a shopping list.
//Its data should be a List<Item>, where Item is another class you create.
//Item should contain a string for the name of the item, and a bool for whether you’ve ticked it off the list.
//Provide member functions on ShoppingList to help with:

//Adding items - it shouldn’t let you add items already on the list, if you do it should should just untick the existing item
//Ticking off items - if the item exists its boolean value should be set to true
//Displaying the list - it should output with checkboxes as shown below, and, if you can, make it display alphabetically

using System.Diagnostics;
run();
void run()
{
    ShoppingList shoppingList = new ShoppingList();
    shoppingList.AddItem("Eggs", 10);
    shoppingList.AddItem("Bacon", 100);
    shoppingList.AddItem("Eggs", 12);
    shoppingList.DisplayList();
    Item searchItem = shoppingList.FindItem("Eggs");
    searchItem.SetQuantity(999);
    shoppingList.DisplayList();
    searchItem.isTicked = !searchItem.isTicked;
    shoppingList.DisplayList();
}
//tests();
void tests()
{
    //Test add item
    {
        ShoppingList shoppingList = new ShoppingList();
        string itemName = "Eggs";
        shoppingList.AddItem(itemName);
        Debug.Assert(shoppingList.items[0].name == "Eggs");
    }
    //Test add item with quantity
    {
        ShoppingList shoppingList = new ShoppingList();
        string itemName = "Eggs";
        int itemQuantity = 12;
        shoppingList.AddItem(itemName, itemQuantity);
        Debug.Assert(shoppingList.items[0].name == "Eggs");
    }
    //Tickoff Item
    {
        ShoppingList shoppingList = new ShoppingList();
        string itemName = "Eggs";
        shoppingList.AddItem(itemName);
        shoppingList.DisplayList();
        shoppingList.TickoffItem(itemName);
        shoppingList.DisplayList();
        Debug.Assert(shoppingList.items[0].isTicked == false);
    }
}
