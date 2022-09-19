// See https://aka.ms/new-console-template for more information

//Creare una classe Prodotto che gestisce i prodotti dello shop.



using System;
using System.Security.Cryptography;

Product firstProduct = new Product();

//codice visibile in scrittura
firstProduct.MakeName("test1");
firstProduct.MakeDescription("lorem ipsum");
firstProduct.MakePrice(17.50);
firstProduct.MakeVAT(25);


//codice visibile in lettura
Console.WriteLine($"Nome completo del prodotto compreso di codice : {firstProduct.CompleteName()}");
Console.WriteLine($"Il codide del prodotto: {firstProduct.GenerateCodeProduct().ToString("D8")}");
Console.WriteLine($"Il nome del prodotto: {firstProduct.ProductName()}");
Console.WriteLine($"La descrizione del prodotto: {firstProduct.ProductDescription()}");
Console.WriteLine($"Il prezzo del prodotto senza IVA: {firstProduct.ProductPrice()}");
Console.WriteLine($"IVA da applicare al prodotto: {firstProduct.ProductVAT()}");
Console.WriteLine($"Il prezzo compreso di IVA è di : {firstProduct.TotalPrice()}");

public class Product
{
    int code;
    string name;
    string description;
    double price;
    int vat;
    double priceVat;

    public Product()
    {
        
    }

    public void MakeName(string name)
    {
       this.name = name;
    }
    public void MakeDescription(string description)
    {
        this.description = description;
    }
    public void MakePrice(double price)
    {
        this.price = price;
    }
    public void MakeVAT(int vat)
    {
        this.vat = vat;
    }

    public int ProductCode()
    {
        return this.code;
    }
    public string ProductName()
    {
        return this.name;
    }
    public string ProductDescription()
    {
        return this.description;
    }
    public double ProductPrice()
    {
        return this.price;
    }
    public int ProductVAT()
    {
        return this.vat;
    }

    public int GenerateCodeProduct()
    {
        return code = new Random().Next(1, 99999999);
    }
    public double TotalPrice()
    {
        return (ProductPrice() * ProductVAT()) / 100 + ProductPrice();
    }

    public string CompleteName()
    {
        return ProductCode() + " " + ProductName();
    }
}

