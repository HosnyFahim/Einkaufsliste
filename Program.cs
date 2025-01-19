List<string> einkaufsliste = new List<string>();

while (true)
{
    Console.WriteLine("\nEinkaufsliste - Optionen:");
    Console.WriteLine("1. Artikel hinzufügen");
    Console.WriteLine("2. Liste anzeigen");
    Console.WriteLine("3. Artikel entfernen");

    string auswahl = Console.ReadLine();

    switch (auswahl)
    {
        case "1":
            ArtikelHinzufuegen();
            break;
        case "2":
            ListeAnzeigen();
            break;
        case "3":
            ArtikelEntfernen();
            break;
        case "4":
            return;
        default:
            Console.WriteLine("Ungültige Option, bitte erneut versuchen.");
            break;
    }
}

 void ArtikelHinzufuegen()
{
    Console.Write("Gib deine Sachen ein: ");
    string artikel = Console.ReadLine();
    einkaufsliste.Add(artikel);
    Console.WriteLine($"Artikel '{artikel}' wurde hinzugefügt.");
}


void ListeAnzeigen()
{
    Console.WriteLine("\nAktuelle Einkaufsliste:");
    if (einkaufsliste.Count == 0)
    {
        Console.WriteLine("Die Einkaufsliste ist leer.");
    }
    else
    {
        foreach (var artikel in einkaufsliste)
        {
            Console.WriteLine($"- {artikel}");
        }
    }
}

void ArtikelEntfernen()
{
    Console.Write("Gib den Namen des Artikels ein, der entfernt werden soll: ");
    string artikel = Console.ReadLine();
    if (einkaufsliste.Remove(artikel))
    {
        Console.WriteLine($"Artikel '{artikel}' wurde entfernt.");
    }
    else
    {
        Console.WriteLine($"Artikel '{artikel}' wurde nicht gefunden.");
    }
}
