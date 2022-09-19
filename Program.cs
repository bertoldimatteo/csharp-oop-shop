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
Console.WriteLine($"Il codide del prodotto: {firstProduct.code}");
Console.WriteLine($"Il nome del prodotto: {firstProduct.name}");
Console.WriteLine($"La descrizione del prodotto: {firstProduct.description}");
Console.WriteLine($"Il prezzo del prodotto senza IVA: {firstProduct.price}");
Console.WriteLine($"IVA da applicare al prodotto: {firstProduct.code}");
Console.WriteLine($"Prezzo finale prodotto compreso di IVA: {firstProduct.priceVat}");

public class Product
{
    public int code;
    public string name;
    public string description;
    public double price;
    public double vat;
    public double priceVat;

    public Product()
    {
        code = new Random().Next(1,9);
    }

    public int totalPrice(int price, int vat)
    {
        this.price = price;
        this.vat = vat;
        int calculation = (price * vat) / 100;
        int totalPrice = price + calculation;
        
        return totalPrice;
    }
}

