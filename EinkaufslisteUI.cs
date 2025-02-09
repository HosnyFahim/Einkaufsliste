using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EinkaufslisteUI
{
    private EinkaufslisteMethoden einkaufsliste;

    public EinkaufslisteUI(EinkaufslisteMethoden liste)
    {
        einkaufsliste = liste;
    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("\nEinkaufsliste - Optionen:");
            Console.WriteLine("1. Artikel hinzufügen");
            Console.WriteLine("2. Liste anzeigen");
            Console.WriteLine("3. Artikel entfernen");
            Console.WriteLine("4. Liste speichern");
            Console.WriteLine("5. Beenden");

            string auswahl = Console.ReadLine();

            switch (auswahl)
            {
                case "1":
                    ArtikelHinzufuegen();
                    break;
                case "2":
                    einkaufsliste.ListeAnzeigen();
                    break;
                case "3":
                    ArtikelEntfernen();
                    break;
                case "4":
                    einkaufsliste.SpeichereListe();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Ungültige Option, bitte erneut versuchen.");
                    break;
            }
        }
    }

    private void ArtikelHinzufuegen()
    {
        Console.Write("Gib deine Sachen ein: ");
        string artikel = Console.ReadLine();
        einkaufsliste.ArtikelHinzufuegen(artikel);
    }

    private void ArtikelEntfernen()
    {
        Console.Write("Gib den Namen des Artikels ein, der entfernt werden soll: ");
        string artikel = Console.ReadLine();
        einkaufsliste.ArtikelEntfernen(artikel);
    }
}
