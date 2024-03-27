
public class Store
{
    private readonly string _name;
    private readonly List<Item> _items;
    private readonly int _maximumCapacity;

    public Store(string name, int maximumCapacity)
    {
        _name = name;
        _items = new List<Item>();
        _maximumCapacity = maximumCapacity;
    }

    public string GetStoreName()
    {
        return _name;
    }

    public int GetStorageItems()
    {
        return _items.Count();
    }

    public int GetMaxCapacity()
    {
        return _maximumCapacity;
    }

    public bool AddItem(Item newItem)
    {
        int availableSpace = GetMaxCapacity() - GetCurrentVolume();

        if (newItem.GetQuantity() > availableSpace)
        {
            throw new Exception("Not enough space available in storage!");
        }

        bool itemExists = _items.Contains(newItem);
        if (!itemExists)
        {
            _items.Add(newItem);
            Console.WriteLine("Added item to storage");
            return true;
        }
        Console.WriteLine("item already exists in storage");
        return false;
    }

    public bool DeleteItem(Item item)
    {
        bool result = _items.Remove(item);
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
        foreach (Item item in _items)
        {
            totalAmount += item.GetQuantity();
        }
        return totalAmount;
    }

    public void GetStorageItemNames()
    {
        foreach (Item item in _items)
        {
            Console.WriteLine($"Name: {item.GetName()}");
        }
    }


    public Item? FindItemByName(string name)
    {
        Item? targetItem = _items.Find(item => item.GetName() == name);
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
            return _items.OrderBy(item => item.GetName()).ToList();
        }
        if (order == SortOrder.DESC)
        {
            return _items.OrderByDescending(item => item.GetName()).ToList();
        }
        return _items;
    }

    public List<Item> SortByDate(SortOrder order)
    {
        if (order == SortOrder.ASC)
        {
            return _items.OrderBy(item => item.GetDateTime()).ToList();
        }
        if (order == SortOrder.DESC)
        {
            return _items.OrderByDescending(item => item.GetDateTime()).ToList();
        }
        return _items;
    }

    // GroupByDate --> perhaps use LINQ operator (GroupBy)?

    // public Dictionary<DateTime, Item> GroupByDate()
    // {
    //     var listByDate = _items.GroupBy(item => item.GetDateTime());
    //     Console.WriteLine(listByDate);
    //     return listByDate.ToDictionary();
    // }


}