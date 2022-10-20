using Rucsac.Articole;

namespace Rucsac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valoriAcceptate = { "1", "2", "3", "4", "5", "6", "7" };
            Console.Clear();
            Console.WriteLine("Introduceti greutatea maxima: ");
            float gmax = CitesteValoareFloat();
            Console.WriteLine("Introduceti volumul maxim: ");
            float vmax = CitesteValoareFloat();
            Console.WriteLine("Introduceti numar maxim articole: ");
            int nmax = CitesteValoareIntreaga();
            Ghiozdan g = new Ghiozdan(gmax, vmax, nmax);
            
            
            Console.Clear();
            Console.WriteLine("Alege un obiect:");
            Console.WriteLine("1) Sageata");
            Console.WriteLine("2) Arc");
            Console.WriteLine("3) Franghie");
            Console.WriteLine("4) Apa");
            Console.WriteLine("5) Portie mancare");
            Console.WriteLine("6) Sabie");
            Console.WriteLine("-------------------");
            Console.WriteLine("7) Iesire");

            string optiune = "-1";
            bool stare = true;

            while (optiune != "7")
            {
                optiune = Console.ReadLine();
                if(valoriAcceptate.Contains(optiune))
                {
                    switch (optiune)
                    {
                        case "1":
                            stare = g.Adauga(new Sageata());
                            break;
                        case "2":
                            stare = g.Adauga(new Arc());
                            break;
                        case "3":
                            stare = g.Adauga(new Franghie());
                            break;
                        case "4":
                            stare = g.Adauga(new Apa());
                            break;
                        case "5":
                            stare = g.Adauga(new PortieDeMancare());
                            break;
                        case "6":
                            stare = g.Adauga(new Sabie());
                            break;
                    }
                    
                    if (stare == false && g.Inventar.Length == g.nrCurentArticole)
                    {
                        Console.WriteLine("Nu mai puteti adauga articole !");
                        break;
                    }
                    else if(stare == false) {
                        Console.WriteLine("Articol invalid, alegati alt articol. ");
                    }
                }
                else
                {
                    Console.WriteLine("Optiune invalida!");
                }
                
            }
            Console.WriteLine(g.ToString());

        }

        //Verifica daca numarul introdus este un intreg.
        //Daca este nr intreg il returneaza altfel afiseaza un mesaj de eroare si asteapta alta valoare
        static int CitesteValoareIntreaga()
        {
            string valoare = Console.ReadLine();
            int x;
            while (!Int32.TryParse(valoare, out x))
            {
                Console.WriteLine("Introduceti un numar intreg !");
                valoare = Console.ReadLine();
            }
            return x;
        }

        //Verifica daca valoarea introdusa este un numar si inceraca sa il converteasca in float.
        //Daca reuseste conversia returneaza numarul, altfel afiseaza un mesaj de eroare si asteapta alta valoare.
        static float CitesteValoareFloat()
        {
            string valoare = Console.ReadLine();
            float x;
            while (!float.TryParse(valoare, out x))
            {
                Console.WriteLine("Introduceti un numar !");
                valoare = Console.ReadLine();
            }
            return x;
        }
    }
}