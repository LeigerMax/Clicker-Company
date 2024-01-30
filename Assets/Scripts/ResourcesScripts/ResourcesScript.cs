
/// <summary>
/// This class is used to store the quantity of a ressource.
/// </summary>
/// <author> Maxou </author>
/// <lastModified>29-01-2024</lastModified>

public class ResourcesScript
{
    private string resourceName;
    private float quantity;

    public float Quantity
    {
        get { return this.quantity; }
        set { this.quantity = value; }
    }

    public string ResourceName
    {
        get { return this.resourceName; }
        set { this.resourceName = value; }
    }

    public ResourcesScript(string ressourceName, float quantity)
    {
        this.resourceName = ressourceName;
        this.quantity = quantity;
    }

    public void AddQuantity(float amount)
    {
        this.quantity += amount;
    }

    public void SubtractQuantity(float amount)
    {
        this.quantity -= amount;
    }
}
