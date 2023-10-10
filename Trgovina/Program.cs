using Trgovina;

//Console.WriteLine(Artikl.tecaj);
Artikl a = new ("Med cvjetni 450g", 4.09M);
Artikl b = new("Kruh")
{
    TipProizvoda = Kategorija.Pecivo
};
//b.TipProizvoda = Kategorija.Napitak;
Console.WriteLine(b.TipProizvoda == Kategorija.Pecivo);
Console.WriteLine((byte)b.TipProizvoda);
Artikl c = new(c: 1.23M, p: 0.25M, n: "Pahuljice coko");
//c.Kolicina = 10;
//c.Kolicina++;
c.Kupi(2);
Console.WriteLine($"Kolicina: {c.Kolicina}");
Console.WriteLine(c.Iznos);
c.IspisHRK();
Artikl d = new("Jos jedan namaz")
{
    Cijena = 5.32M,
    Popust = 0.16M,
    naziv = "Tuna namaz 100g"
};

try
{
    d.Cijena = -5.3M;
    d.Popust = 0.2M;
    Console.WriteLine(d.Cijena);
    //Console.WriteLine(d.Popust);
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}

Kategorija kat = Kategorija.Pecivo;
Console.WriteLine(kat);