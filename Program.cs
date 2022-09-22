// See https://aka.ms/new-console-template for more information

Water acquaPanna = new Water("Acqua Panna", "Acqua del Borneo", 1.75, 25, 7, "Fonte del Borneo");
Water acquaUliveto = new Water("Acqua Uliveto", "Acqua della nazionale Italiana", 2.15, 25, 9, "Fonte del paesino imboscato del Friuli");

acquaPanna.CompleteName();
Console.WriteLine();
acquaPanna.drink(0.25);
Console.WriteLine();
acquaPanna.fill(0.10);
Console.WriteLine();
acquaPanna.gallonConversion(0.25);
Console.WriteLine();
acquaPanna.empty();
Console.WriteLine();

acquaUliveto.CompleteName();
Console.WriteLine();
acquaUliveto.drink(1.5);
Console.WriteLine();
acquaUliveto.fill(0);
Console.WriteLine();
acquaUliveto.gallonConversion(0.5);
Console.WriteLine();
acquaUliveto.empty();
