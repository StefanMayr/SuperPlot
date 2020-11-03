using System;

namespace SuperPlotVorlage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SuperPlot");

            // Geben Sie die Werte für die Zahlen a,b,c ein
            // Verwenden Sie Console.ReadLine und optional double.Parse()

            // Deklarieren Sie eine Variable x = 0;

            // FOR: Schreiben Sie eine For-Schleife für das zeilenweise Vorgehen nach unten
            // Von 20 bis 1

            // IF:Prüfen Sie ob der aktuelle Funktionswert y = a*x*x + b*x *c
            // Gleich dem aktuellen Schleifenindex ist

            // Bilden Sie dazu die Differenz aus Index und y und wenn diese kleiner ist
            // als 1 gehts hier weiter, sonst bei ELSE

            // Geben Sie den Schleifenindex mit Console.Write aus

                // FOR: Schreiben Sie innerhalb der ersten Schleife eine zweite Schleife für
                // das Schreiben der Leerzeichen bis zum Funktionswert

                    // Verwenden Sie Console.Write um Leerzeichen die Zeile zu schreiben

                    // Die Anzahl der Leerzeichen entspricht dem Wert x

                // END_FOR Ende der Leerzeichenschleife

            // Geben Sie den Stern mit Console.Write("*") aus

            // erhöhen Sie x um 1

            // ELSE: wenn die Differenz nicht kleiner ist als 1 
            // Geben Sie den Schleifenindex mit Console.Write aus

            // END_FOR Ende der Zeilenschleife


            // Hinweis zur Funktionsweise:
            // Das Programm berechnet mit steigendem Wert X jeweils immer den Funktionswert y bzw. 
            // f(x) und prüft ob dieser in die aktuelle Zeile geschrieben werden soll oder nicht.
            // Die aktuelle Zeile wird mit der FOR-Schleife gezählt (z.B: von 20 -> 0)
            // Die Position am Bildschirm von links nach rechts wird über eine weitere FOR-Schleife
            // pro Zeile ermittelt welche von 0 -> X zählt

            Console.ReadKey();
        }
    }
}
