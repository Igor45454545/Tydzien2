
Console.Write("Podaj liczbę racji: ");
int liczbaRacji = int.Parse(Console.ReadLine());
Console.Write("Podaj liczbę członków drużyny: ");
int liczbaCzlonkowDruzyny = int.Parse(Console.ReadLine());
Console.Write("Podaj liczbę dni wyprawy: ");
int dniWyprawy = int.Parse(Console.ReadLine());

Console.WriteLine($"\nKażdy członek drużyny otrzyma {liczbaRacji/liczbaCzlonkowDruzyny} pełnych racji");
Console.WriteLine($"Zostanie {liczbaRacji%liczbaCzlonkowDruzyny} racji po równym podziale");
Console.WriteLine($"{(double)liczbaRacji/dniWyprawy} racji na dzień dla całej drużyny");
Console.WriteLine($"{(double)(liczbaRacji / liczbaCzlonkowDruzyny) / dniWyprawy} racji na dzień dla całej drużyny");

