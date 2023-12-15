using NumberToString.Enums;
using NumberToString.Infos;

namespace NumberToString.Converters.Implementations;

/// <inheritdoc />
internal sealed class ConverterUnitNumber : IConverter
{
    /// <inheritdoc />
    public bool CanInvoke(int num)
    {
        return num is >= 0 and <= 9;
    }

    /// <inheritdoc />
    public string NumberToWord(int num, Cases @case, Genus genus)
    {
        if (UnitNumberInfo.CasesNumDictionary.TryGetValue(
                new KeyValuePair<int, Cases>(num, @case),
                out var numStr1))
        {
            return numStr1;
        }

        return UnitNumberInfo.GenresNumDictionary.TryGetValue(
            new KeyValuePair<int, KeyValuePair<Cases, Genus>>(num, new KeyValuePair<Cases, Genus>(@case, genus)), out var numStr2)
            ? numStr2
            : string.Empty;
    }
}