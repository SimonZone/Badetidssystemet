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
            BadetidsPeriode badetidsPeriode = new BadetidsPeriode("Morgen Dukkert",DayOfWeek.Monday,"20/6/2022 7:30:00", "20/6/2022 8:30:00");
            badetidsPeriode.AddKreds(kreds1);
            badetidsPeriode.AddKreds(kreds2);

            Console.WriteLine(badetidsPeriode.ToString());

            Console.WriteLine();
            Console.WriteLine("Klik på en knap for at gå vider");

            Console.ReadKey();
            Console.Clear();
            #endregion
            #region opgave 4:
            BadetidsPeriode badetidsPeriode2 = new BadetidsPeriode("Aftensvaler", DayOfWeek.Tuesday, "21/6/2022 19:30:00", "21/6/2022 20:30:00");
            badetidsPeriode2.AddKreds(kreds1);
            badetidsPeriode2.AddKreds(kreds2);

            Console.WriteLine(badetidsPeriode.ToString());

            badetidsPeriode2.DeleteKreds("0");
            Console.WriteLine("deleted 1");
            Console.WriteLine(badetidsPeriode.ToString());



            Console.WriteLine();
            Console.WriteLine("Klik på en knap for at gå vider");

            Console.ReadKey();
            #endregion


        }
    }
}
