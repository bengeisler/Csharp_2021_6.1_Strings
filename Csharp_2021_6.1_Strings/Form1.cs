using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_2021_6._1_Strings
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			string meinString = "Hallo,Welt,!";

			// String ausgeben
			Console.WriteLine("String ausgeben:");
			Console.WriteLine("->" + meinString + "<-");

			// Anzahl der Zeichen des Strings ausgeben
			Console.WriteLine("Anzahl der Zeichen des Strings: ");
			Console.WriteLine(meinString.Length);

			// String in Kleinbuchstaben ausgeben
			Console.WriteLine("String in Kleinbuchstaben ausgeben:");
			Console.WriteLine(meinString.ToLower());

			// String in Großbuchstaben ausgeben
			Console.WriteLine("String in Großbuchstaben ausgeben:");
			Console.WriteLine(meinString.ToUpper());

			// String rückwärts ausgeben
			Console.WriteLine("String rückwärs ausgeben:");

			// Ansätze:
			// - Länge des Strings bestimmen, sortieren und ausgeben => Index rückwärts ausgeben
			string meinStringRückwärts = "";
			for (int i = meinString.Length - 1; i >= 0; i--)
			{
				meinStringRückwärts += meinString[i];
			}
			Console.WriteLine(meinStringRückwärts);

			// - String in Array (char) umwandeln, Array umdrehen über Reverse(), dann ausgeben
			// - => Datenfeld direkt ausgeben / string in foreach-Schleife neu zusammensetzen
			char[] c = meinString.ToCharArray();
			Array.Reverse(c);
			Console.WriteLine(c);
			// - Buchstaben gegenseitig ersetzen (kompliziert)

			// String über Reverse() umdrehen und in Array wandeln
			Console.WriteLine(meinString.Reverse().ToArray());

			// Zeichen des Strings ersetzen
			Console.WriteLine("Einzelne Elemente des Strings verändern:");
			Console.WriteLine(meinString.Replace("H", "h"));

			// Trim: Leerzeichen entfernen
			Console.WriteLine("Leerzeichen mit Trim() entfernen");
			Console.WriteLine("->" + meinString.Trim() + "<-");

			// Auf einzelne Zeichen des Strings zugreifen
			Console.WriteLine("Einzelne Zeichen des Strings ausgeben:");
			for (int i = 0; i < meinString.Length; i++)
			{
				Console.WriteLine(meinString[i]);
			}

			// Teilstring ausgeben
			Console.WriteLine("Teilstring ausgeben:");
			Console.WriteLine(meinString.Substring(2,2));

			// Contains
			Console.WriteLine("Prüfen, ob String eine Zeichenkette enthält:");
			Console.WriteLine(meinString.Contains("al"));

			// Löschen
			Console.WriteLine("Zeichenkette aus String entfernen:");
			Console.WriteLine(meinString.Remove(2,2));

			// Einfügen
			Console.WriteLine("Zeichenkette einfügen:");
			Console.WriteLine(meinString.Insert(2, "."));

			// Nach einer Zeichenkette suchen
			Console.WriteLine("Nach Zeichenkette suchen:");
			Console.WriteLine(meinString.IndexOf("ll"));

			// Split
			Console.WriteLine("Zeichenkette splitten:");
			string[] teilzeichenketten = meinString.Split(',');
			foreach (var s in teilzeichenketten)
			{
				Console.WriteLine(s);
			}

			// String auf null oder empty prüfen
			Console.WriteLine("Prüfen, ob String null oder empty ist:");
			Console.WriteLine(string.IsNullOrEmpty(meinString));
			Console.WriteLine(string.IsNullOrEmpty(""));

			// Padding: String mit Leerzeichen auffüllen, bis Gesamtlänge erreicht wird
			Console.WriteLine("Padding (links):");
			Console.WriteLine(meinString.PadLeft(15));


			// String-Formatierung
			Console.WriteLine("##### String-Formatierung ######");

			string formatierterString = "123";
			string string2 = "Hallo";
			double meineZahl = 123.15;
			Console.WriteLine("Formatierter String: {0}, {1}", formatierterString, string2);

			// Format "0000" => Ersetzt jede 0 durch eine vorhandene Ziffer;
			// andernfalls werden die Nullen vorne bzw. hinten angehängt, bis die Anzahl der
			// Ziffern erreicht wurde
			Console.WriteLine("Formatierung: 0000000");
			Console.WriteLine("Formatierte Zahl: {0:0000000}", meineZahl);

			Console.WriteLine("Formatierung: 0000.0000");
			Console.WriteLine("Formatierte Zahl: {0:0000.0000}", meineZahl);

			// Format "###"
			// Kreuze werden durch Ziffern ersetzt, falls notwendig
			// Es können jedoch nicht mehr Ziffern als Kreuze ausgegeben werden
			Console.WriteLine("Formatierung: ####.#");
			Console.WriteLine("Formatierte Zahl: {0:####.#}", meineZahl);

			// Tausendertrennpunkt
			Console.WriteLine("Formatierung: ##,#");
			Console.WriteLine("Formatierte Zahl: {0:##,#}", 2147483647);

			// Währung
			Console.WriteLine("Formatierung: C");
			Console.WriteLine("Zahl als Währung formatieren: {0:C}", meineZahl);

			Console.WriteLine("Formatierung: {0:##,#.### €}", meineZahl);

			// Rechtsbündige Ausgabe
			Console.WriteLine("Rechtsbündige Ausgabe: ");
			Console.WriteLine("Rechtsbündig: {0,10}", string2);

			// Linksbündige Ausgabe
			Console.WriteLine("Linksbündige Ausgabe: ");
			Console.WriteLine("Linksbündige: {0,-10}!", string2);

			// Ausgabe über interpolated strings
			Console.WriteLine("Interpolated strings:");
			Console.WriteLine($"Ausgabe: {meineZahl:##.##}");
		}
	}
}
