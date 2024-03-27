
public class Item
{
    private readonly Guid _id = Guid.NewGuid();
    private readonly string _name;
    private int _quantity;
    private DateTime _createdAt;

    public Item(string name, int quantity, DateTime createdAt)
    {
        _name = name;
        _quantity = quantity;
        _createdAt = createdAt;
    }
    public Item(string name, int quantity)
    {
        _name = name;
        _quantity = quantity;
        _createdAt = DateTime.Now;

    }

    public Guid GetId()
    {
        return _id;
    }
    public string GetName()
    {
        return _name;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public DateTime GetDateTime()
    {
        return _createdAt;
    }

    public void SetDateTime(DateTime date)
    {
        _createdAt = date;
    }

}