using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoclass
{
    internal class Auto
    {
        string rendszam;
        string tipusNev;
        double fogyasztas; //100kmenkénti avg
        int kmora;
        int szervizkm;

        int utolsoSzervizKm; //friss szerviz
        double eddigiFogyasztas;
        public Auto(string rendszam, string tipusNev, double fogyasztas, int szervizkm, int kmora = 0)
        {
            this.rendszam = rendszam;
            this.tipusNev = tipusNev;
            this.fogyasztas = fogyasztas;
            this.kmora = kmora;
            this.szervizkm = szervizkm;
            this.utolsoSzervizKm = 0;
            this.eddigiFogyasztas = 0;
        }
        public bool KellSzervizelni()
        {
            return utolsoSzervizKm > szervizkm - 500;
        }

        public void szervizElvegzese()
        {
            this.utolsoSzervizKm = 0;
        }

        public double FelhasznaltUzemanyag()
        { 
            return kmora/100*fogyasztas; // új autó eset
        }

        public string Rendszam { get => rendszam; }
        public string TipusNev { get => tipusNev; }
        public double Fogyasztas { get => fogyasztas; }
        public int Kmora { get => kmora; }
        public int Szervizkm { get => szervizkm; }

        public override string? ToString()
        {
            return $"Rendszám: {this.rendszam}, Típusnév: {this.tipusNev}, Fogyasztás: {this.fogyasztas:F1}l/100km, km óra állása: {this.kmora} ";
        }

        public void Menj(int mennyit)
        {
            if(this.utolsoSzervizKm > szervizkm + 100)
            {
                throw new Exception("Ezt a kocsit szervizelni kell!");
            }
            //todo hibaellenőrzés
            this.kmora += mennyit;
            this.utolsoSzervizKm += mennyit;
            this.eddigiFogyasztas += mennyit / 100 * eddigiFogyasztas;

        }
    }
}
