


using System.Text.RegularExpressions;

namespace _02_Structs.Structs.Domain_Driven_Design;

internal struct Email
{
    private readonly string _value;

    public Email(string aValue)
    {

        _value = aValue;
    }
}
