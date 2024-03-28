
public class Item
{
    private readonly Guid _id = Guid.NewGuid();
    private string _name;
    private int _quantity;

    public int Quantity
    {
        get
        {
            return _quantity;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Quantity cannot be a negative value");
            }
            _quantity = value;
        }
    }
    private DateTime _createdAt;

    public Item(string name, int quantity, DateTime createdAt)
    {
        _name = name;
        Quantity = quantity;
        _createdAt = createdAt;
    }
    public Item(string name, int quantity)
    {
        _name = name;
        Quantity = quantity;
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

    public DateTime GetCreatedAt()
    {
        return _createdAt;
    }

}