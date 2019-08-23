﻿/* 
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
            Console.WriteLine("Augabenteil 1");
            Console.WriteLine("-------------");

            double ltrPro100Km  = 7.4;      // Liter/100km
            double spritPreis   = 1.149;    // Euro/Liter
            int streckeHinZurueck = 4;      // in km
            int tage = 22;

            double kosten = (double)streckeHinZurueck * (ltrPro100Km / 100 * spritPreis) * tage;

            Console.WriteLine("Kosten fuer einen Monat: {0}", kosten);
            Console.ReadKey();
        }
    }
}
