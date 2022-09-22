// See https://aka.ms/new-console-template for more information

public class Product
{
    public int code { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public double price { get; set; }
    public int vat { get; set; }

    public int GenerateCodeProduct()
    {
        return code = new Random().Next(1, 99999999);
    }
    public double TotalPrice()
    {
        return (price * vat) / 100 + price;
    }

    public string CompleteName()
    {
        return code + " " + name;
    }
}

