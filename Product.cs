// See https://aka.ms/new-console-template for more information

class Product
{
    public int code { get; set; } = new Random().Next(1, 99999999);
    public string name { get; set; }
    public string description { get; set; }
    public double price { get; set; }
    public int vat { get; set; }

    public Product(string name, string description, double price, int vat)
    {
        this.name = name;
        this.description = description;
        this.price = price;
        this.vat = vat;
    }

    public double TotalPrice()
    {
        return (price * vat) / 100 + price;
    }

    public virtual void CompleteName()
    {
        Console.WriteLine($"Il codice del prodotto è:{code}");
        Console.WriteLine($"Il nome del prodotto è:{name}");
    }
}
