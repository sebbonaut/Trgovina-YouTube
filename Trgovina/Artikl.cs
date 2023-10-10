using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trgovina
{
    public enum Kategorija : byte
    {
        Pecivo = 2,
        Napitak,
        Meso = 5,
        Ostalo
    }
    public class Artikl
    {
        public string naziv;
        decimal cijena, popust;
        public readonly DateTime stvoren;
        public static readonly decimal tecaj;

        public Kategorija TipProizvoda { get; init; }
        public uint Kolicina { get; private set; } = 10;

        public void Kupi(uint komada)
        {
            Kolicina -= komada;
        }
        
        public decimal Cijena
        {
            get => cijena;
            //set => cijena = value;
            set
            {
                if(value < 0M)
                {
                    throw new ArgumentException("Negativna vrijednost cijene!");
                }
                else
                {
                    cijena = value;
                }
            }
        }
        public decimal Popust
        {
            set => popust = value;
        }

        //public decimal Iznos() => cijena * (1 - popust);
        public decimal Iznos => cijena * (1 - popust);
        public void IspisHRK() =>
            Console.WriteLine(Iznos * tecaj + " HRK");
        static Artikl()
        {
            tecaj = 7.5345M;
        }

        public Artikl(string n, decimal c, decimal p = 0) {
            TipProizvoda = Kategorija.Ostalo;
            naziv = n;
            Cijena = c;
            Popust = p;
            stvoren = DateTime.Now;
        }

        public Artikl(string naziv) : this(naziv, 0)
        {

        }
    }
}
