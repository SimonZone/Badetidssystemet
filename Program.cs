using System;

namespace Badetidssystemet
{
    class Program
    {
        static void Main(string[] args)
        {
            #region opgave 1:
            Kreds kreds1 = new Kreds("1","Girls", "Vej, Nr, By, PostNr",12);
            Kreds kreds2 = new Kreds("2","boys", "Vej, Nr, By, PostNr",7);

            Console.WriteLine(kreds1.ToString());
            Console.WriteLine(kreds2.ToString());

            Console.WriteLine();
            Console.WriteLine("Klik på en knap for at gå vider");

            Console.ReadKey();
            Console.Clear();
            #endregion
            #region opgave 2:
            BadetidsPeriode badetidsPeriode = new BadetidsPeriode("Morgen Dukkert",DayOfWeek.Monday,"20/6/2022 7:30:00", "20/6/2022 8:45:00");
            badetidsPeriode.AddKreds(kreds1);
            badetidsPeriode.AddKreds(kreds2);

            Console.WriteLine(badetidsPeriode.ToString());

            Console.WriteLine();
            Console.WriteLine("Klik på en knap for at gå vider");

            Console.ReadKey();
            Console.Clear();
            #endregion
            #region opgave 4:
            BadetidsPeriode badetidsPeriode2 = new BadetidsPeriode("Aften Svaler", DayOfWeek.Tuesday, "21/6/2022 19:30:00", "21/6/2022 20:20:00");
            badetidsPeriode2.AddKreds(kreds1);
            badetidsPeriode2.AddKreds(kreds2);

            Console.WriteLine(badetidsPeriode2.ToString());
            Console.WriteLine();
            Console.WriteLine("Klik på en knap for at gå vider");

            Console.ReadKey();
            Console.Clear();

            badetidsPeriode2.DeleteKreds("2");
            Console.WriteLine("deleted Kreds 2");
            Console.WriteLine(badetidsPeriode2.ToString());


            Console.WriteLine();
            Console.WriteLine("Klik på en knap for at gå vider");

            Console.ReadKey();
            Console.Clear();
            #endregion
            #region Opgave 6 Validering eksempler
            Kreds kredstest1 = new Kreds("3", "Børn", "Vej, Nr, By, PostNr", 0);
            Kreds kredstest2 = new Kreds("4", "Voksne", "Vej, Nr, By, PostNr", 9);

            Console.WriteLine($"Validerings test AntalDeltagere: der er {kredstest1.AntalDeltagere} i {kredstest1.Navn} og der skal være mere end 0\n");

            Console.WriteLine(kredstest1.ToString());
            Console.WriteLine(kredstest2.ToString());

            Console.WriteLine("Klik på en knap for at gå vider");

            Console.ReadKey();
            Console.Clear();

            BadetidsPeriode badetidsPeriodetest = new BadetidsPeriode("Badning", DayOfWeek.Wednesday, "22/6/2022 15:30:00", "22/6/2022 17:30:00");
            badetidsPeriodetest.AddKreds(kredstest1);
            badetidsPeriodetest.AddKreds(kredstest2);
            Console.WriteLine($"Validerings test Type: {badetidsPeriodetest.Type} er for kort hvis den er mindre end 4 lang\n");
            Console.WriteLine(badetidsPeriodetest.ToString());

            BadetidsPeriode badetidsPeriodetest2 = new BadetidsPeriode("Lej", DayOfWeek.Friday, "25/6/2022 15:30:00", "25/6/2022 17:30:00");
            badetidsPeriodetest2.AddKreds(kredstest1);
            badetidsPeriodetest2.AddKreds(kredstest2);
            Console.WriteLine($"Validerings test Type: {badetidsPeriodetest2.Type} er for kort hvis den er mindre end 4 lang\n");
            Console.WriteLine(badetidsPeriodetest2.ToString());

            Console.WriteLine("Klik på en knap for at gå vider");

            Console.ReadKey();
            Console.Clear();

            BadetidsPeriode badetidsPeriodetest3 = new BadetidsPeriode("Badning", DayOfWeek.Wednesday, "22/6/2022 20:30:00", "22/6/2022 17:30:00");
            badetidsPeriodetest3.AddKreds(kredstest1);
            badetidsPeriodetest3.AddKreds(kredstest2);
            Console.WriteLine($"Validerings test Tidspunkter: {badetidsPeriodetest3.StartTidspunktString} sker efter {badetidsPeriodetest3.SlutTidspunktString}\n");
            Console.WriteLine(badetidsPeriodetest3.ToString());

            Console.WriteLine("Klik på en knap for at gå vider");

            Console.ReadKey();
            Console.Clear();
            #endregion
            #region opgave 10
            Kreds kreds1Clone = new Kreds("1", "Girls", "Vej, Nr, By, PostNr", 12);
            Kreds kreds2Clone = new Kreds("2", "boys", "Vej, Nr, By, PostNr", 7);
            BadetidsPeriodeForLoopAndList badetidsPeriodeForLoopAndList = new BadetidsPeriodeForLoopAndList("Ryksvømning", DayOfWeek.Saturday, "25/6/2022 19:30:00", "25/6/2022 21:00:00");
            badetidsPeriodeForLoopAndList.AddKreds(kreds1Clone);
            badetidsPeriodeForLoopAndList.AddKreds(kreds2Clone);
            Console.WriteLine(badetidsPeriodeForLoopAndList.ToString());

            Console.WriteLine("Klik på en knap for at gå vider");

            Console.ReadKey();
            Console.Clear();
            #endregion
        }
    }
}
