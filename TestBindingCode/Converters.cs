using LambdaConverters;

using System.Windows.Data;

namespace TestBindingCode
{
    internal static class Converters
    {
        public static readonly IValueConverter FloatToString =
            ValueConverter.Create<double, string>(convertFunction: x => x.Value.ToString("c2"),
                                                  convertBackFunction: x => float.Parse(x.Value)); // this is optional
    }
}
