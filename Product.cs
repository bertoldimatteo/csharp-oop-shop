// See https://aka.ms/new-console-template for more information

class Product
{
    public int code { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public double price { get; set; }
    public int vat { get; set; }

    public Product(int code, string name, string description, double price, int vat)
    {
        this.code = code;
        this.name = name;
        this.description = description;
        this.price = price;
        this.vat = vat;
    }

    public int GenerateCodeProduct()
    {
        return code = new Random().Next(1, 99999999);
    }
    public double TotalPrice()
    {
        return (price * vat) / 100 + price;
    }

    public virtual void CompleteName()
    {
        Console.WriteLine($"Il codice del prodotto è:{code}, il nome del prodotto è:{name}");
    }
}
