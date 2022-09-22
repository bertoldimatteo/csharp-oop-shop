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

    public string CompleteName()
    {
        return code + " " + name;
    }
}

class Water: Product 
{
    public double liters { get; set; }
    public int ph { get; }
    public string source { get; }

    public Water(int code, string name, string description, double price, int vat, double liters, int ph, string source): base(code, name, description, price, vat)
    {
        this.liters = liters;
        this.ph = ph;
        this.source = source;
    }

    public double drink(double litersToDrink)
    {
        return liters - litersToDrink;
    }
}