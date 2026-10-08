using System;

string imie = "Mira";
char symbol = '@';
int poziom = 2;
int zloto = 35;
double waga = 7.5;
bool maMape = true;

Console.WriteLine("=== EKWIPUNEK ===");
Console.WriteLine($"Imię (string): {imie}");
Console.WriteLine($"Symbol (char): {symbol}");
Console.WriteLine($"Poziom (int): {poziom}");
Console.WriteLine($"Złoto (int): {zloto}");
Console.WriteLine($"Waga (double): {waga} kg");
Console.WriteLine($"Ma mapę (bool): {maMape}");

zloto+=35;
poziom*=10;

Console.WriteLine("=== EKWIPUNEK ===");
Console.WriteLine($"Imię (string): {imie}");
Console.WriteLine($"Symbol (char): {symbol}");
Console.WriteLine($"Poziom (int): {poziom}");
Console.WriteLine($"Złoto (int): {zloto}");
Console.WriteLine($"Waga (double): {waga} kg");
Console.WriteLine($"Ma mapę (bool): {maMape}");

