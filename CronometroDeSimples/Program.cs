// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Stopwatch stopwatch = new Stopwatch();

Console.WriteLine("Pressione 's' para iniciar o cronômetro e 'p' para parar.");

while(true)
{
    var key = Console.ReadLine(true);

    if (key, keyChar == 's')
}
else if (Key.KeyChar == 'p')
{
    stopwatch.Stop();

    Console.WriteLine($"Cronômetro parado. Tempo Decorrido: {stopwatch.Elapsed.TotalSeconds} segundos.")
break;
}
