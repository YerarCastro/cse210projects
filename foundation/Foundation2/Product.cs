public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    //constructor

    public Product (string name, string productid, double price, int quantity)
    {
        _name = name;
        _productId = productid;
        _price = price;
        _quantity = quantity;
    }

        // Getters
     public string GetName() => _name;
     public string GetProductId() => _productId;
     public double GetPrice() => _price;
     public int GetQuantity() => _quantity;


     public double GetTotalCost ()
     {
        return _price * _quantity;
     }













}