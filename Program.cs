// See https://aka.ms/new-console-template for more information

//Creare una classe Prodotto che gestisce i prodotti dello shop.



Product firstProduct = new Product();

firstProduct.code = 1;
firstProduct.name = "test1";
firstProduct.description = "lorem ipsum";
firstProduct.price = 19.50;
firstProduct.vat = 25;

Console.WriteLine(firstProduct.code);
Console.WriteLine(firstProduct.name);
Console.WriteLine(firstProduct.description);
Console.WriteLine(firstProduct.price);
Console.WriteLine(firstProduct.vat);

public class Product
{
    public int code;
    public string name;
    public string description;
    public double price;
    public int vat;
}

