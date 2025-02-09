using System;

class Program
{
    static void Main()
    {
        EinkaufslisteMethoden einkaufsliste = new EinkaufslisteMethoden();
        EinkaufslisteUI ui = new EinkaufslisteUI(einkaufsliste);
        ui.Start();
    }
}