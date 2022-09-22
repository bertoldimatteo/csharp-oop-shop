// See https://aka.ms/new-console-template for more information

class Water: Product 
{
    public double liters { get; set; }
    public int ph { get; }
    public string source { get; }
    private double maxLiters { get; set; } = 1.5;
    private double currentLiters { get; set; }

    public Water(string name, string description, double price, int vat, int ph, string source): base(name, description, price, vat)
    {
        this.ph = ph;
        this.source = source;
    }

    public void drink(double litersToDrink)
    {
        currentLiters = maxLiters;

        if (currentLiters > 0) {
            currentLiters = maxLiters - litersToDrink;
            Console.WriteLine($"Hai bevuto {litersToDrink} la bottiglia ha ancora {currentLiters} litri");
        }else
        {
            Console.WriteLine("E' finita l'acqua");
        }
    }

    public void fill(double liters)
    {
        if(currentLiters > 0 && currentLiters < maxLiters)
        {
            currentLiters += liters;
            Console.WriteLine($"Hai rimpieto la bottiglia con {liters} litri, la bottiglia ora ha {currentLiters} litri");
        }
        else if (currentLiters == 0)
        {
            Console.WriteLine("La bottiglia d'acqua è vuota");
        }else if (currentLiters == maxLiters)
        {
            Console.WriteLine("La bottiglia d'acqua è piena");
        }
    }

    public void empty()
    {
        if(currentLiters > 0)
        {
            currentLiters = 0;
            Console.WriteLine("Hai svuotato la bottiglia");
        } else
        {
            Console.WriteLine("La bottiglia di acqua è gia vuota");
        }
    }

    public void gallonConversion(double liters)
    {
        double gallon = 3.785;
        double converted = gallon * liters;
        Console.WriteLine($"Hai inserito {liters} litri, convertito in galloni ottieni {converted}");
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