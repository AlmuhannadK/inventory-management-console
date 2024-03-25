class Program
{
    private static void Main(string[] args)
    {
        var waterBottle = new Item("Water Bottle", 10, new DateTime(2023, 1, 1));
        var chocolateBar = new Item("Chocolate Bar", 15, new DateTime(2023, 2, 1));
        var notebook = new Item("Notebook", 5, new DateTime(2023, 3, 1));
        var pen = new Item("Pen", 20, new DateTime(2023, 4, 1));
        var tissuePack = new Item("Tissue Pack", 30, new DateTime(2023, 5, 1));
        var chipsBag = new Item("Chips Bag", 25, new DateTime(2023, 6, 1));
        var sodaCan = new Item("Soda Can", 8, new DateTime(2023, 7, 1));
        var soap = new Item("Soap", 12, new DateTime(2023, 8, 1));
        var shampoo = new Item("Shampoo", 40, new DateTime(2023, 9, 1));
        var toothbrush = new Item("Toothbrush", 50, new DateTime(2023, 10, 1));
        var coffee = new Item("Coffee", 20);
        var sandwich = new Item("Sandwich", 15);
        var batteries = new Item("Batteries", 10);
        var umbrella = new Item("Umbrella", 5);
        var sunscreen = new Item("Sunscreen", 8);


        Store myStore = new Store();

        myStore.AddItem(waterBottle);
        myStore.AddItem(pen);
        myStore.AddItem(soap);
        myStore.AddItem(coffee);
        myStore.AddItem(batteries);
        myStore.AddItem(umbrella);

        Console.WriteLine(myStore.GetCurrentVolume());
        Console.WriteLine("============================================");
        myStore.GetStorageItemNames();
        Console.WriteLine("============================================");

        myStore.DeleteItem(waterBottle);
        myStore.DeleteItem(umbrella);
        Console.WriteLine("AFTER DELETE");
        Console.WriteLine(myStore.GetCurrentVolume());
        myStore.GetStorageItemNames();
        Console.WriteLine("============================================");

        var targetItem1 = myStore.FindItemByName("Pen");
        Console.WriteLine(targetItem1.GetName());

        Console.WriteLine("============================================");

        List<Item> myList = myStore.SortByNameAsc();
        myList.ForEach(item =>
        {
            Console.WriteLine(item.GetName());
        });









    }
}