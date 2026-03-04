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
        double eddigpenz;
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
            this.eddigpenz = 0;
        }
        public bool KellSzervizelni()
        {
            return utolsoSzervizKm > szervizkm - 500;
        }

        public void SzervizElvegzese()
        {
            this.utolsoSzervizKm = 0;
        }

        public double FelhasznaltUzemanyag()
        {
            return eddigiFogyasztas;
        }
        public double mennyiForintbaVan()
        {
            return eddigiFogyasztas * 600;
        }

        public string Rendszam { get => rendszam; }
        public string TipusNev { get => tipusNev; }
        public double Fogyasztas { get => fogyasztas; }
        public int Kmora { get => kmora; }
        public int Szervizkm { get => szervizkm; }

        public override string? ToString()
        {
            return $"Rendszám: {this.rendszam}, Típusnév: {this.tipusNev}, Fogyasztás: {this.fogyasztas:F1}l/100km, km óra állása: {this.kmora},  összfogyasztás:{this.eddigiFogyasztas:F2}l, eddig ennyit kellett rá költeni: {this.eddigpenz:F0}Ft";
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
            this.eddigiFogyasztas += mennyit / 100 * fogyasztas;
            this.eddigpenz += eddigiFogyasztas * 600;
        }
    }
}
