using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    struct Adress
    {
        string ulica;
        int numer;
        string miasto;
        string kod_pocztowy;

        public Adress(string ulica, int numer, string miasto, string kod_pocztowy)
        {
            this.ulica = ulica;
            this.numer = numer;
            this.miasto = miasto;
            this.kod_pocztowy = kod_pocztowy;
        }

        public override string ToString()
        {
            return ulica + " " + numer.ToString() + " " + miasto + " " + kod_pocztowy;
        }



    }
    abstract class Humanoid
    {
        string Imie;
        string Nazwisko;

        Adress adres;

        public Humanoid(string Imie, string Nazwisko, Adress adres)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.adres = adres;
        }

        public virtual string ToString()
        {
            return Imie + " " + Nazwisko + " " + adres.ToString();
        }
    }

    class Student : Humanoid
    {
        string index_number;
        public Student(string Imie, string Nazwisko, Adress adres, string index_number)
            : base(Imie, Nazwisko, adres)
        {
            this.index_number = index_number;
        }

        public override string ToString()
        {
            return (base.ToString() + " " + index_number);
        }

    }

    class Prowadzacy : Humanoid
    {
        int numer;

        public Prowadzacy(string Imie, string Nazwisko, Adress adres, int numer)
            : base(Imie, Nazwisko, adres)
        {
            this.numer = numer;
        }

        public override string ToString()
        {
            return (base.ToString() + " " + numer);
        }

    }

    abstract class Zajecia
    {
        List<DateTime> terminy;
        string nazwa;
        Prowadzacy prowadzacy;

        public Zajecia(string nazwa, Prowadzacy prowadzacy)
        {
            this.nazwa = nazwa;
            this.prowadzacy = prowadzacy;
        }


    }

    class Cwiczenia : Zajecia
    {

        public Cwiczenia(string nazwa, Prowadzacy prowadzacy)
            : base(nazwa, prowadzacy)
        {

        }
    }

    class Laboratoria : Zajecia
    {
        Prowadzacy prowadzacy2;
        public Laboratoria(string nazwa, Prowadzacy prowadzacy, Prowadzacy prowadzacy2)
            : base(nazwa, prowadzacy)
        {
            this.prowadzacy2 = prowadzacy2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {




            Humanoid test = new Student("ssa", "sdsd", new Adress("ul.", 2, "City", "221"), "2323");
            Humanoid test2 = new Prowadzacy("aaa", "sasdasdaaaasd", new Adress("ul.", 2, "City2", "221"), 1);

            Console.WriteLine(test.ToString());
            Console.WriteLine(test2.ToString());

            List<Cwiczenia> cwiczenia = new List<Cwiczenia>();

            cwiczenia.Add(new Cwiczenia("nowe", (Prowadzacy)test2));
            cwiczenia.Add(new Cwiczenia("nowe2", (Prowadzacy)test2));

            Console.ReadKey();

        }
    }
}
