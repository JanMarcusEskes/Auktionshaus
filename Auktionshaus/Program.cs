using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auktionshaus
{
  class Program
  {
    static void Main(string[] args)
    {
      double StartPreis, VerkaufsPreis, Provision = 0, GesamtGebühr, AngebotsGebühr = 0;

      Console.Title = "AuktionOS";
      Console.WriteLine("Start Preis (in Euro)......: ");
      double.TryParse(Console.ReadLine(), out StartPreis);
      Console.WriteLine("Verkaufspreis (in Euro)....: ");
      double.TryParse(Console.ReadLine(), out VerkaufsPreis);

      if (StartPreis > 1) AngebotsGebühr = 0.25;
      if (StartPreis >= 2) AngebotsGebühr = 0.45;
      if (StartPreis >= 10) AngebotsGebühr = 0.8;
      if (StartPreis >= 25) AngebotsGebühr = 1.6;
      if (StartPreis >= 100) AngebotsGebühr = 3.2;
      if (StartPreis >= 250) AngebotsGebühr = 4.8;

      if (VerkaufsPreis >= 1) Provision = VerkaufsPreis * 0.09;
      if (Provision > 45) Provision = 45;

      GesamtGebühr = AngebotsGebühr + Provision;

      Console.Clear();
      Console.WriteLine("Start-Preis.....: " + StartPreis);
      Console.WriteLine("Verkaufs-Preis..: " + VerkaufsPreis);
      Console.WriteLine("");
      Console.WriteLine("Provison........: " + Provision);
      Console.WriteLine("Angebotsgebühr..: " + AngebotsGebühr);
      Console.WriteLine("------------------------------------");
      Console.WriteLine("Gesamtbetrag....: " + GesamtGebühr);
      Console.ReadLine();

    }
  }
}
