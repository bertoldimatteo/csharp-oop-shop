// See https://aka.ms/new-console-template for more information

//Creare una classe Prodotto che gestisce i prodotti dello shop.



using System;
using System.Security.Cryptography;

Product firstProduct = new Product();

//codice visibile in scrittura
firstProduct.name = "test1";
firstProduct.description = "lorem ipsum";
firstProduct.price = 19.50;
firstProduct.vat = 25;

//codice visibile in lettura
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

    public Product()
    {
        code = new Random().Next(1,9);
    }
}

