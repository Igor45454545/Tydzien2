Console.Write("Punkty życia: ");
int punktyZycia = int.Parse(Console.ReadLine());
Console.Write("Liczba mikstur: ");
int liczbaMikstur = int.Parse(Console.ReadLine());
Console.Write("Czy masz klucz (true/false): ");
bool maKlucz = bool.Parse(Console.ReadLine());
Console.Write("Czy masz mapę (true/false): ");
bool maMape = bool.Parse(Console.ReadLine());

bool zyje = punktyZycia > 0;
// if(punktyZycia > 0) zyje = true; else zyje = false;
bool maPelneZdrowie = punktyZycia == 100;
// if(punktyZycia == 100) maPelneZdrowie = true; else maPelneZdrowie = false;
bool maZaopatrzenie = liczbaMikstur >= 1;
// if(liczbaMikstur >= 1) maZaopatrzenie = true; else maZaopatrzenie = false;
bool maPrzedmiotNawigacyjny = maKlucz || maMape;
// if(maKlucz || maMape) maPrzedmiotNawigacyjny = true; else maPrzedmiotNawigacyjny = false;
bool gotowyDoWyprawy = zyje && maZaopatrzenie && maPrzedmiotNawigacyjny;
// if(zyje && maZaopatrzenie && maPrzedmiotNawigacyjny) gotowyDoWyprawy = true; else gotowyDoWyprawy = false;
bool wymagaleczenia = !maPelneZdrowie;

Console.WriteLine($"Żyje: {zyje}");
Console.WriteLine($"Ma pełne zdrowie: {maPelneZdrowie}");
Console.WriteLine($"Wymaga leczenia: {wymagaleczenia}");
Console.WriteLine($"Ma zaopatrzenie: {maZaopatrzenie}");
Console.WriteLine($"Ma klucz lub mapę: {maPrzedmiotNawigacyjny}");
Console.WriteLine($"Gotowy do wyprawy: {gotowyDoWyprawy}");