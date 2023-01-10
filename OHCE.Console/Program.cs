using OHCE;
using OHCE.Console;

var ohce = new Ohce(new SystemLangProxy(), new SystemTimePeriodeJourneeAdapter().PériodeJournée);

Console.WriteLine(new SystemTimePeriodeJourneeAdapter().PériodeJournée);

Console.WriteLine(ohce.Saluer());


Console.WriteLine(ohce.Palindrome(Console.ReadLine() ?? String.Empty));

Console.WriteLine(ohce.AuRevoir());
