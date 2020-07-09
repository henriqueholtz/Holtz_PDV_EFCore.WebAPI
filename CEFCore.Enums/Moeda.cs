using System.Globalization;

namespace EFCore.Enums
{
    public class Moeda
    {
        public string ToString(double Value)
        {
            return Value.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}