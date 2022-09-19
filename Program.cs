// See https://aka.ms/new-console-template for more information

//Creare una classe Prodotto che gestisce i prodotti dello shop.

public class Product
{
    int code;
    string name;
    string description;
    double price;
    int vat;

    public Product()
    {
        Random rnd = new Random();
        code = rnd.Next();
    }
}
