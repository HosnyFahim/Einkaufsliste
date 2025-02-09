using System;
using System.Collections.Generic;
using System.IO;

public class EinkaufslisteMethoden
{
    private List<string> artikelListe = new List<string>();

    public void ArtikelHinzufuegen(string artikel)
    {
        artikel = artikel.Trim(); // Entfernt überflüssige Leerzeichen

        if (string.IsNullOrEmpty(artikel))
        {
            Console.WriteLine("Artikelname darf nicht leer sein!.");
            return;
        }

        artikelListe.Add(artikel);
        Console.WriteLine($"Artikel '{artikel}' wurde hinzugefügt.");
    }

    public void ListeAnzeigen()
    {
        Console.WriteLine("\nAktuelle Einkaufsliste:");
        if (artikelListe.Count == 0)
        {
            Console.WriteLine("Die Einkaufsliste ist leer.");
        }
        else
        {
            foreach (var artikel in artikelListe)
            {
                Console.WriteLine($"- {artikel}");
            }
        }
    }

    public void ArtikelEntfernen(string artikel)
    {
        artikel = artikel.Trim(); // Entfernt führende und nachfolgende Leerzeichen

        string artikelZumEntfernen = artikelListe.Find(a => a.Equals(artikel, StringComparison.OrdinalIgnoreCase));

        if (artikelZumEntfernen != null)
        {
            artikelListe.Remove(artikelZumEntfernen);
            Console.WriteLine($"Artikel '{artikel}' wurde entfernt.");
        }
        else
        {
            Console.WriteLine($"Artikel '{artikel}' wurde nicht gefunden.");
        }
    }

    public void SpeichereListe()
    {
        string desktopPfad = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Einkaufsliste.txt");

        if (artikelListe.Count == 0)
        {
            Console.WriteLine("Die Einkaufsliste ist leer. Es gibt nichts zu speichern.");
            return;
        }

        try
        {
            File.WriteAllLines(desktopPfad, artikelListe);
            Console.WriteLine($"Einkaufsliste wurde in '{desktopPfad}' gespeichert.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Fehler beim Speichern: {ex.Message}");
        }
    }
}