﻿// See https://aka.ms/new-console-template for more information

class Water: Product 
{
    public double liters { get; set; }
    public int ph { get; }
    public string source { get; }
    private double maxLiters { get; set; } = 1.5;
    private double currentLiters { get; set; } = 0;

    public Water(int code, string name, string description, double price, int vat, double liters, int ph, string source): base(code, name, description, price, vat)
    {
        this.liters = liters;
        this.ph = ph;
        this.source = source;
    }

    public void drink(double litersToDrink)
    {
        if (liters > 0) {
            currentLiters = maxLiters - litersToDrink;
        }else
        {
            Console.WriteLine("E' finita l'acqua");
        }
    }

    public void fill(double liters)
    {
        if(currentLiters < maxLiters && currentLiters > 0)
        {
            currentLiters += liters;
        }else
        {
            Console.WriteLine("La bottiglia d'acqua è piena");
        }
    }

    public void empty()
    {
        if(currentLiters > 0)
        {
            currentLiters = 0;
        } else
        {
            Console.WriteLine("La bottiglia di acqua è gia vuota");
        }
    }

    public override void CompleteName()
    {
        Console.WriteLine($"Il codice del prodotto è:{code}");
        Console.WriteLine($"Il nome del prodotto è:{name}");
        Console.WriteLine($"La sorgente di provenienza dell'acqua è:{source}");
        Console.WriteLine($"Il PH contenuto nell'acqua è di:{ph}");
        Console.WriteLine($"Litri contenuti in ogni bottiglia:{maxLiters}");
    }
}