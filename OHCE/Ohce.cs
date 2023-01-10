using System.Text;

namespace OHCE;

public class Ohce
{
    private readonly ILangue _langue;
    private readonly PériodeJournée _périodeJournée;

    public Ohce(ILangue langue, PériodeJournée périodeJournée)
    {
        _langue = langue;
        _périodeJournée = périodeJournée;
    }

    public string Palindrome(string input)
    {
        var stringBuilder = 
            new StringBuilder();

        var reversed = new string(
            input.Reverse().ToArray()
        );

        stringBuilder.Append(reversed);

        if (reversed.Equals(input))
            stringBuilder.Append("\n" + _langue.BienDit);


        return stringBuilder.ToString();
    }

    public string Saluer()
    {
        return _langue.DireBonjour(_périodeJournée);
    }

    public string AuRevoir()
    {
        return _langue.AuRevoir;
    }
}