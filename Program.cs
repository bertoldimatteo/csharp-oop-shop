﻿// See https://aka.ms/new-console-template for more information

Water acquaPanna = new Water("Acqua Panna", "Acqua del Borneo", 1.75, 25, 7, "Fonte del Borneo");

acquaPanna.CompleteName();
Console.WriteLine();
acquaPanna.drink(0.25);
Console.WriteLine();
acquaPanna.fill(0.10);
Console.WriteLine();
acquaPanna.gallonConversion(0.25);
Console.WriteLine();
acquaPanna.empty();