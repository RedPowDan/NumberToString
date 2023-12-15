using NumberToString.Converters.Implementations;
using NumberToString.Enums;

namespace NumberToString.Converters;

/// <inheritdoc />
internal sealed class AggregateConverter : IConverter
{
    private readonly IConverter[] _converters =
    {
        new ConverterHundredNumber(),
        new ConverterTenNumber(),
        new ConverterUnitNumber(),
        new ConverterTenToNineteenNumber()
    };

    /// <inheritdoc />
    public bool CanInvoke(int num)
    {
        return true;
    }

    /// <inheritdoc />
    public string NumberToWord(int num, Cases @case, Genus genus)
    {
        var converter = this._converters.FirstOrDefault(x => x.CanInvoke(num));

        return converter is null
            ? string.Empty
            : converter.NumberToWord(num, @case, genus);
    }
}