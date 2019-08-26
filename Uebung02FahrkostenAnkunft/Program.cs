/* 
 * Übung: Verwendung der Datentypen 'int' und 'double', 
 *        sowie der arithmetischen Operatoren
 * 
 *        1.Aufgabe
 * 
 *          Angenommen, ein Fahrzeug Ihrer Wahl habe:
 * 
 *            - einen Kraftstoffverbrauch von 'double ltrPro100Km' (z.B. 7.4)
 *            - einen Kraftstoffpreis 'double spritPreis' (€/ltr, z.B. 1.149)
 * 
 *          Sie fahren damit jeweils eine Strecke 'int strecke' (in km)
 *          und ein Monat hat 22 Schultage.
 * 
 *          Was kostet Sie die Fahrt hin und zurück zu alfatraining in einem Monat?
 * 
 *        2.Aufgabe
 * 
 *          Angenommen, Sie fahren die folgende Route:
 * 
 *            - Abfahrt ist um 14:15h in Ravensburg
 *            - zunächst fahren Sie 50 km Landstrasse, mit einem Schnitt von 60 km/h
 *            - dann 90 km mit einem Schnitt von 110 km/h
 *            - dann 10 km mit einem Schnitt von 70 km/h
 *            - dann 30 km mit einem Schnitt von 120 km/h
 *            - dann 10 km mit einem Schnitt von 50 km/h
 *            - dann 60 km mit einem Schnitt von 90 km/h
 *            
 *          Nach diesen Fahrtabschnitten sind Sie in Karlsruhe,
 *          aber zu welcher Uhrzeit (im Format 'Stunden:Minuten')?
 * 
 *        Hinweis: Verwenden Sie die explizite Konvertierung von Datentypen
 * 
 *                 Beispiel: Konvertierung von 'double' nach 'int'
 * 
 *                           double kosten = (double)strecke * ...
 */


using System;

namespace Uebung02FahrkostenAnkunft
{
    class Program
    {
        static void Main(string[] args)
        {


//       1.Aufgabe
//
//      Angenommen, ein Fahrzeug Ihrer Wahl habe:
//      -einen Kraftstoffverbrauch von 'double ltrPro100Km'(z.B. 7.4)
//      -einen Kraftstoffpreis 'double spritPreis'(€/ ltr, z.B. 1.149)
//      Sie fahren damit jeweils eine Strecke 'int strecke'(in km)
//      und ein Monat hat 22 Schultage.
//      Was kostet Sie die Fahrt hin und zurück zu alfatraining in einem Monat?

            Console.WriteLine("Augabenteil 1");
            Console.WriteLine("-------------");

            double ltrPro100Km  = 7.4;      // Liter/100km
            double spritPreis   = 1.149;    // Euro/Liter
            int streckeHinZurueck = 4;      // in km
            int tage = 22;

            double kosten = (double)streckeHinZurueck * (ltrPro100Km / 100 * spritPreis) * tage;

            Console.WriteLine("Kosten fuer einen Monat: {0}", kosten);




            /*        2.Aufgabe
            * 
            *          Angenommen, Sie fahren die folgende Route:
            * 
            *            - Abfahrt ist um 14:15h in Ravensburg
            *            - zunächst fahren Sie 50 km Landstrasse, mit einem Schnitt von 60 km/h
            *            - dann 90 km mit einem Schnitt von 110 km/h
            *            - dann 10 km mit einem Schnitt von 70 km/h
            *            - dann 30 km mit einem Schnitt von 120 km/h
            *            - dann 10 km mit einem Schnitt von 50 km/h
            *            - dann 60 km mit einem Schnitt von 90 km/h
            *            
            *          Nach diesen Fahrtabschnitten sind Sie in Karlsruhe,
            *          aber zu welcher Uhrzeit (im Format 'Stunden:Minuten')?
            * 
            *        Hinweis: Verwenden Sie die explizite Konvertierung von Datentypen
            * 
            *                 Beispiel: Konvertierung von 'double' nach 'int'
            * 
            *                           double kosten = (double)strecke * ...
            */


            Console.WriteLine();
            Console.WriteLine("Augabenteil 2");
            Console.WriteLine("-------------");

            DateTime startZeit = new DateTime(2019,08,26,14,15,0);
            double sumZeit = 0.0;

            sumZeit += berechneZeit(60.0, 50.0);
            sumZeit += berechneZeit(110.0, 90.0);
            sumZeit += berechneZeit(70.0, 10.0);
            sumZeit += berechneZeit(120.0, 30.0);
            sumZeit += berechneZeit(50.0, 10.0);
            sumZeit += berechneZeit(90.0, 60.0);

            TimeSpan ts = TimeSpan.FromHours(sumZeit);

            DateTime endZeit = startZeit.AddHours(ts.Hours);
            endZeit = endZeit.AddMinutes(ts.Minutes);
            endZeit = endZeit.AddSeconds(ts.Seconds);

            Console.WriteLine("Abfahrt um {0}:{1}::{2}", startZeit.Hour, startZeit.Minute, startZeit.Second);

            Console.WriteLine("Dauer der Fahrt: {0} Stunden ", sumZeit);
            Console.WriteLine("Dauer der Fahrt als Zeit: {0}:{1}::{2} ", ts.Hours, ts.Minutes, ts.Seconds);

            Console.WriteLine("Ankunft um {0}:{1}::{2}",endZeit.Hour, endZeit.Minute, endZeit.Second);


            Console.ReadKey();
        }



        static double berechneZeit(double geschwindigkeit, double strecke)
        {
            double zeit = strecke / geschwindigkeit;
            //Console.WriteLine("Zeit {0} = {1}/{2} ", zeit,strecke, geschwindigkeit);
            return zeit; // in hrs
        }

    }
}
