class Program
{
    private static void Main(string[] args)
    {
        Item item1 = new("Greek Yogurt", 15);
        Item item2 = new("Milk", 30);
        Item item3 = new("Bread", 40);
        Item item4 = new("Peanut Butter", 8);
        Item item5 = new("Eggs", 24);
        Item notebook = new("Notebook", 5, new DateTime(2023, 3, 1));


        Store store = new Store();

        store.AddItem(item1);
        store.AddItem(item2);
        store.AddItem(item3);
        store.AddItem(item4);
        store.AddItem(item5);
        store.AddItem(notebook);

        Console.WriteLine(store.GetCurrentVolume());
        store.GetStorageItemNames();
        Console.WriteLine("=======================");

        //delete test (works)
        store.DeleteItem(notebook);
        store.DeleteItem(item1);
        store.GetStorageItemNames();

        Console.WriteLine("=======================");

        //SortByNameAsc test
        store.SortByNameAsc();

    }
}