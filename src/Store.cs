
public class Store
{
    private readonly string _name;
    private readonly List<Item> _storage;

    public Store(string name)
    {
        _name = name;
        _storage = [];
    }

    public string GetStoreName()
    {
        return _name;
    }

    public int GetStorageItems()
    {
        return _storage.Count();
    }

    public bool AddItem(Item newItem)
    {
        bool itemExists = _storage.Contains(newItem);
        if (!itemExists)
        {
            _storage.Add(newItem);
            Console.WriteLine("Added item to storage");
            return true;
        }
        Console.WriteLine("item already exists in storage");
        return false;
    }

    public bool DeleteItem(Item item)
    {
        bool result = _storage.Remove(item);
        if (result)
        {
            Console.WriteLine("Item deleted from inventory!");
            return true;
        }
        return false;
    }

    public int GetCurrentVolume()
    {
        int totalAmount = 0;
        foreach (Item item in _storage)
        {
            totalAmount += item.GetQuantity();
        }
        return totalAmount;
    }

    public void GetStorageItemNames()
    {
        foreach (Item item in _storage)
        {
            Console.WriteLine($"Name: {item.GetName()}");
        }
    }


    public Item? FindItemByName(string name)
    {
        Item? targetItem = _storage.Find(item => item.GetName() == name);
        if (targetItem is null)
        {
            Console.WriteLine("item not in storage");
        }
        return targetItem;
    }

    public List<Item> SortByName(SortOrder order)
    {
        if (order == SortOrder.ASC)
        {
            return _storage.OrderBy(item => item.GetName()).ToList();
        }
        if (order == SortOrder.DESC)
        {
            return _storage.OrderByDescending(item => item.GetName()).ToList();
        }
        else
        {
            return _storage;
        }
    }

}